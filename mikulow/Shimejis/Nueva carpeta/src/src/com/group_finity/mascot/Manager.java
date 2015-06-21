package com.group_finity.mascot;

import java.util.ArrayList;
import java.util.ConcurrentModificationException;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.Set;
import java.util.logging.Level;
import java.util.logging.Logger;

import com.group_finity.mascot.config.Configuration;
import com.group_finity.mascot.exception.BehaviorInstantiationException;
import com.group_finity.mascot.exception.CantBeAliveException;

/**
 * 
 * �}�X�R�b�g�̃��X�g���Ǘ����A�^�C�~���O�����I�u�W�F�N�g.
 * 
 * @author Yuki Yamada
 */
public class Manager {

	private static final Logger log = Logger.getLogger(Manager.class.getName());

	/**
	 * �^�C�}�̎��s�Ԋu.
	 */
	public static final int TICK_INTERVAL = 40;

	/**
	 * �}�X�R�b�g�̈ꗗ.
	 */
	private final List<Mascot> mascots = new ArrayList<Mascot>();

	/**
	 * �ǉ������\��̃}�X�R�b�g�̃��X�g.
	 * {@link ConcurrentModificationException} ��h�����߁A�}�X�R�b�g�̒ǉ��� {@link #tick()} ���Ƃɂ��������ɔ��f�����.
	 */
	private final Set<Mascot> added = new LinkedHashSet<Mascot>();

	/**
	 * �ǉ������\��̃}�X�R�b�g�̃��X�g.
	 * {@link ConcurrentModificationException} ��h�����߁A�}�X�R�b�g�̍폜�� {@link #tick()} ���Ƃɂ��������ɔ��f�����.
	 */
	private final Set<Mascot> removed = new LinkedHashSet<Mascot>();

	private boolean exitOnLastRemoved;
	
	private Thread thread;

	public void setExitOnLastRemoved(boolean exitOnLastRemoved) {
		this.exitOnLastRemoved = exitOnLastRemoved;
	}

	public boolean isExitOnLastRemoved() {
		return exitOnLastRemoved;
	}

	public Manager() {

		new Thread() {
			{
				this.setDaemon(true);
				this.start();
			}

			@Override
			public void run() {
				while (true) {
					try {
						Thread.sleep(Integer.MAX_VALUE);
					} catch (final InterruptedException ex) {
					}
				}
			}
		};
	}
	
	public void start() {
		if ( thread!=null && thread.isAlive() ) {
			return;
		}
		
		thread = new Thread() {
			@Override
			public void run() {

				long prev = System.nanoTime() / 1000000;
				try {
					for (;;) {
						for (;;) {
							final long cur = System.nanoTime() / 1000000;
							if (cur - prev >= TICK_INTERVAL) {
								if (cur > prev + TICK_INTERVAL * 2) {
									prev = cur;
								} else {
									prev += TICK_INTERVAL;
								}
								break;
							}
							Thread.sleep(1, 0);
						}

						tick();
					}
				} catch (final InterruptedException e) {
				}
			}
		};
		thread.setDaemon(false);
		
		thread.start();
	}
	
	public void stop() {
		if ( thread==null || !thread.isAlive() ) {
			return;
		}
		thread.interrupt();
		try {
			thread.join();
		} catch (InterruptedException e) {
		}
	}

	private void tick() {

		// �܂��������X�V
		NativeFactory.getInstance().getEnvironment().tick();

		synchronized (this.getMascots()) {

			// �ǉ����ׂ��}�X�R�b�g��ǉ�
			for (final Mascot mascot : this.getAdded()) {
				this.getMascots().add(mascot);
			}
			this.getAdded().clear();

			// �폜���ׂ��}�X�R�b�g���폜
			for (final Mascot mascot : this.getRemoved()) {
				this.getMascots().remove(mascot);
			}
			this.getRemoved().clear();

			// �}�X�R�b�g�̎��Ԃ�i�߂�
			for (final Mascot mascot : this.getMascots()) {
				mascot.tick();
			}
			// �}�X�R�b�g�̎��Ԃ�i�߂�
			for (final Mascot mascot : this.getMascots()) {
				mascot.apply();
			}
		}

		if (isExitOnLastRemoved()) {
			if (this.getMascots().size() == 0) {
				Main.getInstance().exit();
			}
		}
	}

	public void add(final Mascot mascot) {
		synchronized (this.getAdded()) {
			this.getAdded().add(mascot);
			this.getRemoved().remove(mascot);
		}
		mascot.setManager(this);
	}

	public void remove(final Mascot mascot) {
		synchronized (this.getAdded()) {
			this.getAdded().remove(mascot);
			this.getRemoved().add(mascot);
		}
		mascot.setManager(null);
	}

	public void setBehaviorAll(final Configuration configuration, final String name) {
		synchronized (this.getMascots()) {
			for (final Mascot mascot : this.getMascots()) {
				try {
					mascot.setBehavior(configuration.buildBehavior(name));
				} catch (final BehaviorInstantiationException e) {
					log.log(Level.SEVERE, "���̍s���̏������Ɏ��s���܂���", e);
					mascot.dispose();
				} catch (final CantBeAliveException e) {
					log.log(Level.SEVERE, "�s�������邱�Ƃ��o���Ȃ���", e);
					mascot.dispose();
				}
			}
		}
	}

	public void remainOne() {
		synchronized (this.getMascots()) {
			for (int i = this.getMascots().size() - 1; i > 0; --i) {
				this.getMascots().get(i).dispose();
			}
		}
	}

	public int getCount() {
		synchronized (this.getMascots()) {
			return this.getMascots().size();
		}
	}

	private List<Mascot> getMascots() {
		return this.mascots;
	}

	private Set<Mascot> getAdded() {
		return this.added;
	}

	private Set<Mascot> getRemoved() {
		return this.removed;
	}

	public void disposeAll() {
		synchronized (this.getMascots()) {
			for (int i = this.getMascots().size() - 1; i >= 0; --i) {
				this.getMascots().get(i).dispose();
			}
		}
	}
}
