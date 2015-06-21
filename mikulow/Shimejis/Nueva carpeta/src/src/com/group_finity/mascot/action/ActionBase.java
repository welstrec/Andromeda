package com.group_finity.mascot.action;

import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import com.group_finity.mascot.Mascot;
import com.group_finity.mascot.animation.Animation;
import com.group_finity.mascot.environment.MascotEnvironment;
import com.group_finity.mascot.exception.LostGroundException;
import com.group_finity.mascot.exception.VariableException;
import com.group_finity.mascot.script.Variable;
import com.group_finity.mascot.script.VariableMap;

/**
 * �A�N�V�����̋��ʋ@�\���������钊�ۃN���X.
 * @author Yuki Yamada
 */
public abstract class ActionBase implements Action {

	private static final Logger log = Logger.getLogger(ActionBase.class.getName());

	public static final String PARAMETER_DURATION = "����";

	private static final boolean DEFAULT_CONDITION = true;

	public static final String PARAMETER_CONDITION = "����";

	private static final int DEFAULT_DURATION = Integer.MAX_VALUE;

	private Mascot mascot;

	private int startTime;

	private List<Animation> animations;

	private VariableMap variables;

	public ActionBase(final List<Animation> animations, final VariableMap context) {
		this.animations = animations;
		this.variables = context;
	}

	@Override
	public String toString() {
		try {
			return "����(" + getClass().getSimpleName() + "," + getName() + ")";
		} catch (final VariableException e) {
			return "����(" + getClass().getSimpleName() + "," + null + ")";
		}
	}

	@Override
	public void init(final Mascot mascot) throws VariableException {
		this.setMascot(mascot);
		this.setTime(0);

		log.log(Level.INFO, "����J�n({0},{1})", new Object[] { getMascot(), this });

		// �X�N���v�g�Ŏg�p�ł���悤��mascot��action��ϐ��}�b�v�ɒǉ����Ă���
		this.getVariables().put("mascot", mascot);
		this.getVariables().put("action", this);

		// �ϐ��̒l��������
		getVariables().init();

		// �A�j���[�V������������
		for (final Animation animation : this.animations) {
			animation.init();
		}
	}

	@Override
	public void next() throws LostGroundException, VariableException {
		initFrame();
		tick();
	}

	private void initFrame() {

		// �ϐ��̒l(�t���[������)��������
		getVariables().initFrame();

		// �A�j���[�V�����̃t���[����������
		for (final Animation animation : getAnimations()) {
			animation.initFrame();
		}
	}

	private List<Animation> getAnimations() {
		return this.animations;
	}

	protected abstract void tick() throws LostGroundException, VariableException;

	@Override
	public boolean hasNext() throws VariableException {

		final boolean effective = isEffective();
		final boolean intime = getTime() < getDuration();

		return effective && intime;
	}

	private Boolean isEffective() throws VariableException {
		return eval(PARAMETER_CONDITION, Boolean.class, DEFAULT_CONDITION);
	}

	private int getDuration() throws VariableException {
		return eval(PARAMETER_DURATION, Number.class, DEFAULT_DURATION).intValue();
	}

	private void setMascot(final Mascot mascot) {
		this.mascot = mascot;
	}

	protected Mascot getMascot() {
		return this.mascot;
	}

	protected int getTime() {
		return getMascot().getTime() - this.startTime;
	}

	protected void setTime(final int time) {
		this.startTime = getMascot().getTime() - time;
	}

	private String getName() throws VariableException {
		return this.eval("���O", String.class, null);
	}

	protected Animation getAnimation() throws VariableException {
		for (final Animation animation : getAnimations()) {
			if (animation.isEffective(getVariables())) {
				return animation;
			}
		}

		log.log(Level.SEVERE, "�L���ȃA�j���[�V�������������܂���ł���({0},{1})", new Object[] { getMascot(), this });
		return null;
	}

	private VariableMap getVariables() {
		return this.variables;
	}

	protected void putVariable(final String key, final Object value) {
		synchronized (getVariables()) {
			getVariables().put(key, value);
		}
	}

	protected <T> T eval(final String name, final Class<T> type, final T defaultValue) throws VariableException {

		synchronized (getVariables()) {
			final Variable variable = getVariables().getRawMap().get(name);
			if (variable != null) {
				return type.cast(variable.get(getVariables()));
			}
		}

		return defaultValue;
	}

	protected MascotEnvironment getEnvironment() {
		return getMascot().getEnvironment();
	}
}
