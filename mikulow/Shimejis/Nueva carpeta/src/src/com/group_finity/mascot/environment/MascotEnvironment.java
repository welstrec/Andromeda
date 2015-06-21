package com.group_finity.mascot.environment;

import java.awt.Point;

import com.group_finity.mascot.Mascot;
import com.group_finity.mascot.NativeFactory;

public class MascotEnvironment {

	private Environment impl = NativeFactory.getInstance().getEnvironment();

	private Mascot mascot;

	private Area currentWorkArea;

	public MascotEnvironment(Mascot mascot) {
		this.mascot = mascot;
	}

	/**
	 * �}�X�R�b�g���܂ރX�N���[�����擾����
	 * @return
	 */
	public Area getWorkArea() {

		if ( currentWorkArea!=null ) {
			// NOTE Windows �}���`���j�^�Ή� Windows�̃��[�N�G���A�̓��C���̃X�N���[����菬�����B
			// ���݂̃X�N���[�������[�N�G���A���܂�ł���A���}�X�R�b�g�����[�N�G���A�Ɋ܂܂�Ă���Ȃ�΃��[�N�G���A��D�悷��B
			if ( currentWorkArea!=impl.getWorkArea() && currentWorkArea.toRectangle().contains(impl.getWorkArea().toRectangle()) ) {
				if (impl.getWorkArea().contains(mascot.getAnchor().x, mascot.getAnchor().y)) {
					currentWorkArea = impl.getWorkArea();
					return currentWorkArea;
				}
			}

			// NOTE �}���`���j�^�Ή� �}�X�R�b�g�������̃��j�^�ɓ����Ɋ܂܂��ꍇ�����邪�A
			// ���̏ꍇ�͌��݂̃��j�^��D�悷��
			if ( currentWorkArea.contains(mascot.getAnchor().x, mascot.getAnchor().y) ) {
				return currentWorkArea;
			}
		}

		// �܂����[�N�G���A�Ɋ܂܂�Ă��邩���ׂ�
		if (impl.getWorkArea().contains(mascot.getAnchor().x, mascot.getAnchor().y)) {
			currentWorkArea = impl.getWorkArea();
			return currentWorkArea;
		}

		// �e���j�^�Ɋ܂܂�Ă��邩���ׂ�
		for( Area area: impl.getScreens() ) {
			if ( area.contains(mascot.getAnchor().x, mascot.getAnchor().y) ) {
				currentWorkArea = area;
				return currentWorkArea;
			}
		}

		currentWorkArea = impl.getWorkArea();
		return currentWorkArea;

	}

	public Area getActiveIE() {
		return impl.getActiveIE();
	}

	public Border getCeiling() {
		return getCeiling(false);
	}
	public Border getCeiling(boolean ignoreSeparator) {
		if ( getActiveIE().getBottomBorder().isOn(mascot.getAnchor())) {
			return getActiveIE().getBottomBorder();
		}
		if ( getWorkArea().getTopBorder().isOn(mascot.getAnchor()) ) {
			if ( !ignoreSeparator ||isScreenTopBottom() ) {
				return getWorkArea().getTopBorder();
			}
		}
		return NotOnBorder.INSTANCE;
	}

	public ComplexArea getComplexScreen() {
		return impl.getComplexScreen();
	}

	public Location getCursor() {
		return impl.getCursor();
	}

	public Border getFloor() {
		return getFloor(false);
	}

	public Border getFloor(boolean ignoreSeparator) {
		if ( getActiveIE().getTopBorder().isOn(mascot.getAnchor())) {
			return getActiveIE().getTopBorder();
		}
		if ( getWorkArea().getBottomBorder().isOn(mascot.getAnchor()) ) {
			if ( !ignoreSeparator ||isScreenTopBottom() ) {
				return getWorkArea().getBottomBorder();
			}
		}
		return NotOnBorder.INSTANCE;
	}

	public Area getScreen() {
		return impl.getScreen();
	}

	public Border getWall() {
		return getWall(false);
	}

	public Border getWall(boolean ignoreSeparator) {
		if ( mascot.isLookRight()) {
			if ( getActiveIE().getLeftBorder().isOn(mascot.getAnchor())) {
				return getActiveIE().getLeftBorder();
			}

			if ( getWorkArea().getRightBorder().isOn(mascot.getAnchor()) ) {
				if ( !ignoreSeparator || isScreenLeftRight() ) {
					return getWorkArea().getRightBorder();
				}
			}
		} else {
			if ( getActiveIE().getRightBorder().isOn(mascot.getAnchor())) {
				return getActiveIE().getRightBorder();
			}

			if ( getWorkArea().getLeftBorder().isOn(mascot.getAnchor()) ) {
				if ( !ignoreSeparator ||isScreenLeftRight() ) {
					return getWorkArea().getLeftBorder();
				}
			}
		}

		return NotOnBorder.INSTANCE;
	}

	public void moveActiveIE(Point point) {
		impl.moveActiveIE(point);
	}

	public void restoreIE() {
		impl.restoreIE();
	}

	private boolean isScreenTopBottom() {
		return impl.isScreenTopBottom(mascot.getAnchor());
	}

	private boolean isScreenLeftRight() {
		return impl.isScreenLeftRight(mascot.getAnchor());
	}

}
