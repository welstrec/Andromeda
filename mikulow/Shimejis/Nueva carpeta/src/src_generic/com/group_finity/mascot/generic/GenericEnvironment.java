package com.group_finity.mascot.generic;

import java.awt.Point;

import com.group_finity.mascot.environment.Area;
import com.group_finity.mascot.environment.Environment;

/**
 * Java �ł͎擾�����������JNI���g�p���Ď擾����.
 */
class GenericEnvironment extends Environment {

	private Area activeIE = new Area();

	@Override
	public void tick() {
		super.tick();
		this.activeIE.setVisible(false);
	}

	@Override
	public void moveActiveIE(final Point point) {
	}

	@Override
	public void restoreIE() {

	}

	@Override
	public Area getWorkArea() {
		return getScreen();
	}

	@Override
	public Area getActiveIE() {
		return this.activeIE;
	}

}
