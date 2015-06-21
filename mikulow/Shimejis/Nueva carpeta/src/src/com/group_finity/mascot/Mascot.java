package com.group_finity.mascot;

import java.awt.MenuItem;
import java.awt.Point;
import java.awt.PopupMenu;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.logging.Level;
import java.util.logging.Logger;

import javax.swing.JMenuItem;
import javax.swing.JPopupMenu;
import javax.swing.JSeparator;
import javax.swing.SwingUtilities;
import javax.swing.event.PopupMenuEvent;
import javax.swing.event.PopupMenuListener;

import com.group_finity.mascot.action.Action;
import com.group_finity.mascot.behavior.Behavior;
import com.group_finity.mascot.environment.MascotEnvironment;
import com.group_finity.mascot.exception.CantBeAliveException;
import com.group_finity.mascot.image.MascotImage;
import com.group_finity.mascot.image.TranslucentWindow;

/**
 * �}�X�R�b�g�I�u�W�F�N�g.
 *
 * �}�X�R�b�g�͒����I�ŕ��G�ȐU�镑��������킷 {@link Behavior} �ƁA
 * �Z���I�ŒP���ȓ�����\�� {@link Action} �œ���.
 *
 * �}�X�R�b�g�͓����I�Ƀ^�C�}�������Ă��āA���Ԋu���Ƃ� {@link Action} ���Ăяo��.
 * {@link Action} �� {@link #animate(Point, MascotImage, boolean)} ���\�b�h�Ȃǂ��ĂԂ��Ƃ�
 * �}�X�R�b�g���A�j���[�V����������.
 *
 * {@link Action} ���I��������A���̑��̓���̃^�C�~���O�� {@link Behavior} ���Ăяo����A���� {@link Action} �Ɉڂ�.
 *
 */
public class Mascot {

	private static final long serialVersionUID = 1L;

	private static final Logger log = Logger.getLogger(Mascot.class.getName());

	private static AtomicInteger lastId = new AtomicInteger();

	private static boolean showSystemTrayMenu = false;

	public static void setShowSystemTrayMenu(boolean showSystemTrayMenu) {
		Mascot.showSystemTrayMenu = showSystemTrayMenu;
	}

	public static boolean isShowSystemTrayMenu() {
		return showSystemTrayMenu;
	}

	private final int id;

	/**
	 * �}�X�R�b�g��\������E�B���h�E.
	 */
	private final TranslucentWindow window = NativeFactory.getInstance().newTransparentWindow();

	/**
	 * �}�X�R�b�g���Ǘ����Ă���}�l�[�W��.
	 */
	private Manager manager = null;

	/**
	 * �}�X�R�b�g�̐ڒn���W.
	 * ���Ƃ��Α�����A�Ԃ牺�����Ă���Ƃ��̎�̕����Ȃ�.
	 * �������摜��\������Ƃ��̒��S�ɂȂ�.
	 */
	private Point anchor = new Point(0, 0);

	/**
	 * �\������摜.
	 */
	private MascotImage image = null;

	/**
	 * �E�������ǂ���.
	 * �I���W�i���摜�͍������Ƃ��Ĉ�����̂ŁAtrue��ݒ肷��Ɣ��]���ĕ`�悳���.
	 */
	private boolean lookRight = false;

	/**
	 * �����I�ȐU�镑��������킷�I�u�W�F�N�g.
	 */
	private Behavior behavior = null;

	/**
	 * �^�C�}�[��1�`�b�N���Ƃɑ������鎞��.
	 */
	private int time = 0;

	/**
	 * �A�j���[�V�������s�����ǂ���.
	 */
	private boolean animating = true;

	private MascotEnvironment environment = new MascotEnvironment(this);

	public Mascot() {
		this.id = lastId.incrementAndGet();

		log.log(Level.INFO, "�}�X�R�b�g����({0})", this);

		// ��ɍőP�ʂɕ\��
		getWindow().asJWindow().setAlwaysOnTop(true);

		// �}�E�X�n���h����o�^
		getWindow().asJWindow().addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(final MouseEvent e) {
				Mascot.this.mousePressed(e);
			}

			@Override
			public void mouseReleased(final MouseEvent e) {
				Mascot.this.mouseReleased(e);
			}
		});

	}

	@Override
	public String toString() {
		return "�}�X�R�b�g" + this.id;
	}

	private void mousePressed(final MouseEvent event) {

		// �}�E�X�������ꂽ��h���b�O�A�j���[�V�����ɐ؂�ւ���
		if (getBehavior() != null) {
			try {
				getBehavior().mousePressed(event);
			} catch (final CantBeAliveException e) {
				log.log(Level.SEVERE, "�s�������邱�Ƃ��o���Ȃ���", e);
				dispose();
			}
		}

	}

	private void mouseReleased(final MouseEvent event) {

		if (event.isPopupTrigger()) {
			SwingUtilities.invokeLater(new Runnable(){
				@Override
				public void run() {
					showPopup(event.getX(), event.getY());
				}
			});
		} else {
			if (getBehavior() != null) {
				try {
					getBehavior().mouseReleased(event);
				} catch (final CantBeAliveException e) {
					log.log(Level.SEVERE, "�s�������邱�Ƃ��o���Ȃ���", e);
					dispose();
				}
			}
		}

	}

	private void showPopup(final int x, final int y) {
		final JPopupMenu popup = new JPopupMenu();

		popup.addPopupMenuListener(new PopupMenuListener() {
			@Override
			public void popupMenuCanceled(final PopupMenuEvent e) {
			}

			@Override
			public void popupMenuWillBecomeInvisible(final PopupMenuEvent e) {
				setAnimating(true);
			}

			@Override
			public void popupMenuWillBecomeVisible(final PopupMenuEvent e) {
				setAnimating(false);
			}
		});

		final JMenuItem disposeMenu = new JMenuItem("�΂��΂�");
		disposeMenu.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(final ActionEvent e) {
				dispose();
			}
		});

		popup.add(disposeMenu);

		if (isShowSystemTrayMenu()) {

			popup.add(new JSeparator());

			// �u���₷�v���j���[�A�C�e��
			final JMenuItem increaseMenu = new JMenuItem("���₷");
			increaseMenu.addActionListener(new ActionListener() {
				public void actionPerformed(final ActionEvent event) {
					Main.getInstance().createMascot();
				}
			});

			// �u���܂�I�v���j���[�A�C�e��
			final JMenuItem gatherMenu = new JMenuItem("���܂�I");
			gatherMenu.addActionListener(new ActionListener() {
				public void actionPerformed(final ActionEvent event) {
					getManager().setBehaviorAll(Main.getInstance().getConfiguration(), Main.BEHAVIOR_GATHER);
				}
			});

			// �u��C�����c���v���j���[�A�C�e��
			final JMenuItem oneMenu = new JMenuItem("��C�����c��");
			oneMenu.addActionListener(new ActionListener() {
				public void actionPerformed(final ActionEvent event) {
					getManager().remainOne();
				}
			});

			// �uIE�����ɖ߂��v���j���[�A�C�e��
			final JMenuItem restoreMenu = new JMenuItem("IE�����ɖ߂�");
			restoreMenu.addActionListener(new ActionListener() {
				public void actionPerformed(final ActionEvent event) {
					NativeFactory.getInstance().getEnvironment().restoreIE();
				}
			});

			// �u�S���΂��΂��v���j���[�A�C�e��
			final JMenuItem closeMenu = new JMenuItem("�S���΂��΂�");
			closeMenu.addActionListener(new ActionListener() {
				public void actionPerformed(final ActionEvent e) {
					Main.getInstance().exit();
				}
			});

			popup.add(increaseMenu);
			popup.add(gatherMenu);
			popup.add(oneMenu);
			popup.add(restoreMenu);
			popup.add(new JSeparator());
			popup.add(closeMenu);
		}

		getWindow().asJWindow().requestFocus();

		popup.show(getWindow().asJWindow(), x, y);

	}

	void tick() {
		if (isAnimating()) {
			if (getBehavior() != null) {

				try {
					getBehavior().next();
				} catch (final CantBeAliveException e) {
					log.log(Level.SEVERE, "�s�������邱�Ƃ��o���Ȃ���", e);
					dispose();
				}

				setTime(getTime() + 1);
			}
		}
	}

	public void apply() {
		if (isAnimating()) {

			// �\���ł���摜��������Ή����o���Ȃ�
			if (getImage() != null) {

				// �E�B���h�E�̗̈��ݒ�
				getWindow().asJWindow().setBounds(getBounds());

				// �摜��ݒ�
				getWindow().setImage(getImage().getImage());

				// �\��
				if (!getWindow().asJWindow().isVisible()) {
					getWindow().asJWindow().setVisible(true);
				}

				// �ĕ`��
				getWindow().updateImage();
			} else {
				if (getWindow().asJWindow().isVisible()) {
					getWindow().asJWindow().setVisible(false);
				}
			}
		}
	}

	public void dispose() {
		log.log(Level.INFO, "�}�X�R�b�g�j��({0})", this);

		getWindow().asJWindow().dispose();
		if (getManager() != null) {
			getManager().remove(Mascot.this);
		}
	}

	public Manager getManager() {
		return this.manager;
	}

	public void setManager(final Manager manager) {
		this.manager = manager;
	}

	public Point getAnchor() {
		return this.anchor;
	}

	public void setAnchor(final Point anchor) {
		this.anchor = anchor;
	}

	public MascotImage getImage() {
		return this.image;
	}

	public void setImage(final MascotImage image) {
		this.image = image;
	}

	public boolean isLookRight() {
		return this.lookRight;
	}

	public void setLookRight(final boolean lookRight) {
		this.lookRight = lookRight;
	}

	public Rectangle getBounds() {

		// �ڒn���W�Ɖ摜�̒��S���W����E�B���h�E�̗̈�����߂�.
		final int top = getAnchor().y - getImage().getCenter().y;
		final int left = getAnchor().x - getImage().getCenter().x;

		final Rectangle result = new Rectangle(left, top, getImage().getSize().width, getImage().getSize().height);

		return result;
	}

	public int getTime() {
		return this.time;
	}

	private void setTime(final int time) {
		this.time = time;
	}

	public Behavior getBehavior() {
		return this.behavior;
	}

	public void setBehavior(final Behavior behavior) throws CantBeAliveException {
		this.behavior = behavior;
		this.behavior.init(this);
	}

	public int getTotalCount() {
		return getManager().getCount();
	}

	private boolean isAnimating() {
		return this.animating;
	}

	private void setAnimating(final boolean animating) {
		this.animating = animating;
	}

	private TranslucentWindow getWindow() {
		return this.window;
	}

	public MascotEnvironment getEnvironment() {
		return environment;
	}
}
