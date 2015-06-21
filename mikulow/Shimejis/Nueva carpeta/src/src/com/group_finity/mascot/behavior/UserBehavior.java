package com.group_finity.mascot.behavior;

import java.awt.Point;
import java.awt.event.MouseEvent;
import java.util.logging.Level;
import java.util.logging.Logger;

import javax.swing.SwingUtilities;

import com.group_finity.mascot.Mascot;
import com.group_finity.mascot.action.Action;
import com.group_finity.mascot.config.Configuration;
import com.group_finity.mascot.environment.MascotEnvironment;
import com.group_finity.mascot.exception.BehaviorInstantiationException;
import com.group_finity.mascot.exception.CantBeAliveException;
import com.group_finity.mascot.exception.LostGroundException;
import com.group_finity.mascot.exception.VariableException;

/**
 * �T���v���p�̒P���ȐU�镑��.
 */
public class UserBehavior implements Behavior {
	private static final Logger log = Logger.getLogger(UserBehavior.class.getName());

	public static final String BEHAVIORNAME_FALL = "��������";

	public static final String BEHAVIORNAME_THROWN = "��������";

	public static final String BEHAVIORNAME_DRAGGED = "�h���b�O�����";

	private final String name;

	private final Configuration configuration;

	private final Action action;

	private Mascot mascot;

	public UserBehavior(final String name, final Action action, final Configuration configuration) {
		this.name = name;
		this.configuration = configuration;
		this.action = action;
	}

	@Override
	public String toString() {
		return "�s��(" + getName() + ")";
	}

	@Override
	public synchronized void init(final Mascot mascot) throws CantBeAliveException {

		this.setMascot(mascot);

		log.log(Level.INFO, "�s���J�n({0},{1})", new Object[] { this.getMascot(), this });

		try {
			getAction().init(mascot);
			if (!getAction().hasNext()) {
				try {
					mascot.setBehavior(this.getConfiguration().buildBehavior(getName(), mascot));
				} catch (final BehaviorInstantiationException e) {
					throw new CantBeAliveException("���̍s���̏������Ɏ��s���܂���", e);
				}
			}
		} catch (final VariableException e) {
			throw new CantBeAliveException("�ϐ��̕]���ŃG���[���������܂���", e);
		}

	}

	private Configuration getConfiguration() {
		return this.configuration;
	}

	private Action getAction() {
		return this.action;
	}

	private String getName() {
		return this.name;
	}

	/**
	 * �}�E�X�������ꂽ.
	 * ���{�^����������h���b�O�J�n.
	 * @throws CantBeAliveException 
	 */
	public synchronized void mousePressed(final MouseEvent event) throws CantBeAliveException {

		if (SwingUtilities.isLeftMouseButton(event)) {
			// �h���b�O�J�n�̂��m�点
			try {
				getMascot().setBehavior(this.getConfiguration().buildBehavior(BEHAVIORNAME_DRAGGED));
			} catch (final BehaviorInstantiationException e) {
				throw new CantBeAliveException("�h���b�O�s���̏������Ɏ��s���܂���", e);
			}
		}

	}

	/**
	 * �}�E�X�����ꂽ.
	 * ���{�^����������h���b�O�I��.
	 * @throws CantBeAliveException 
	 */
	public synchronized void mouseReleased(final MouseEvent event) throws CantBeAliveException {

		if (SwingUtilities.isLeftMouseButton(event)) {
			// �h���b�O�I���̂��m�点
			try {
				getMascot().setBehavior(this.getConfiguration().buildBehavior(BEHAVIORNAME_THROWN));
			} catch (final BehaviorInstantiationException e) {
				throw new CantBeAliveException("�h���b�v�s���̏������Ɏ��s���܂���", e);
			}
		}

	}

	@Override
	public synchronized void next() throws CantBeAliveException {

		try {
			if (getAction().hasNext()) {
				getAction().next();
			}

			if (getAction().hasNext()) {

				// ��ʊO�ɏo�Ă��܂�����
				if ((getMascot().getBounds().getX() + getMascot().getBounds().getWidth() <= getEnvironment().getScreen()
						.getLeft())
						|| (getEnvironment().getScreen().getRight() <= getMascot().getBounds().getX())
						|| (getEnvironment().getScreen().getBottom() <= getMascot().getBounds().getY())) {

					log.log(Level.INFO, "��ʂ̊O�ɏo��({0},{1})", new Object[] { getMascot(), this });

					getMascot().setAnchor(
							new Point((int) (Math.random() * (getEnvironment().getScreen().getRight() - getEnvironment()
									.getScreen().getLeft()))
									+ getEnvironment().getScreen().getLeft(), getEnvironment().getScreen().getTop() - 256));

					try {
						getMascot().setBehavior(this.getConfiguration().buildBehavior(BEHAVIORNAME_FALL));
					} catch (final BehaviorInstantiationException e) {
						throw new CantBeAliveException("������s���̏������Ɏ��s���܂���", e);
					}
				}

			} else {
				log.log(Level.INFO, "�s������({0},{1})", new Object[] { getMascot(), this });

				try {
					getMascot().setBehavior(this.getConfiguration().buildBehavior(getName(), getMascot()));
				} catch (final BehaviorInstantiationException e) {
					throw new CantBeAliveException("���̍s���̏������Ɏ��s���܂���", e);
				}
			}
		} catch (final LostGroundException e) {
			log.log(Level.INFO, "�n�ʂ��痣�ꂽ({0},{1})", new Object[] { getMascot(), this });

			try {
				getMascot().setBehavior(this.getConfiguration().buildBehavior(BEHAVIORNAME_FALL));
			} catch (final BehaviorInstantiationException ex) {
				throw new CantBeAliveException("������s���̏������Ɏ��s���܂���", ex);
			}
		} catch (final VariableException e) {
			throw new CantBeAliveException("�ϐ��̕]���ŃG���[���������܂���", e);
		}

	}

	private void setMascot(final Mascot mascot) {
		this.mascot = mascot;
	}

	private Mascot getMascot() {
		return this.mascot;
	}

	protected MascotEnvironment getEnvironment() {
		return getMascot().getEnvironment();
	}
}
