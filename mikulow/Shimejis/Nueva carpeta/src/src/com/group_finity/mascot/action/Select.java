package com.group_finity.mascot.action;

import java.util.logging.Logger;

import com.group_finity.mascot.script.VariableMap;

/**
 * �����̃A�N�V������������Ɉ�v�������������s����A�N�V����.
 * @author Yuki Yamada
 */
public class Select extends ComplexAction {

	private static final Logger log = Logger.getLogger(Select.class.getName());

	public Select(final VariableMap params, final Action... actions) {
		super(params, actions);
	}

}
