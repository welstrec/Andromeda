package com.group_finity.mascot.config;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;

import com.group_finity.mascot.behavior.Behavior;
import com.group_finity.mascot.behavior.UserBehavior;
import com.group_finity.mascot.exception.ActionInstantiationException;
import com.group_finity.mascot.exception.BehaviorInstantiationException;
import com.group_finity.mascot.exception.ConfigurationException;
import com.group_finity.mascot.exception.VariableException;
import com.group_finity.mascot.script.Variable;
import com.group_finity.mascot.script.VariableMap;

public class BehaviorBuilder {

	private static final Logger log = Logger.getLogger(BehaviorBuilder.class.getName());

	private final Configuration configuration;

	private final String name;

	private final String actionName;

	private final int frequency;

	private final List<String> conditions;

	private final boolean nextAdditive;

	private final List<BehaviorBuilder> nextBehaviorBuilders = new ArrayList<BehaviorBuilder>();

	private final Map<String, String> params = new LinkedHashMap<String, String>();

	public BehaviorBuilder(final Configuration configuration, final Entry behaviorNode, final List<String> conditions) {
		this.configuration = configuration;
		this.name = behaviorNode.getAttribute("���O");
		this.actionName = behaviorNode.getAttribute("����") == null ? getName() : behaviorNode.getAttribute("����");
		this.frequency = Integer.parseInt(behaviorNode.getAttribute("�p�x"));
		this.conditions = new ArrayList<String>(conditions);
		this.getConditions().add(behaviorNode.getAttribute("����"));

		log.log(Level.INFO, "�s���ǂݍ��݊J�n({0})", this);

		this.getParams().putAll(behaviorNode.getAttributes());
		this.getParams().remove("���O");
		this.getParams().remove("����");
		this.getParams().remove("�p�x");
		this.getParams().remove("����");

		boolean nextAdditive = true;

		for (final Entry nextList : behaviorNode.selectChildren("���̍s�����X�g")) {

			log.log(Level.INFO, "���̍s�����X�g...");

			nextAdditive = Boolean.parseBoolean(nextList.getAttribute("�ǉ�"));

			loadBehaviors(nextList, new ArrayList<String>());
		}
		
		this.nextAdditive = nextAdditive;

		log.log(Level.INFO, "�s���ǂݍ��݊���({0})", this);

	}

	@Override
	public String toString() {
		return "�s��(" + getName() + "," + getFrequency() + "," + getActionName() + ")";
	}

	private void loadBehaviors(final Entry list, final List<String> conditions) {
		
		for (final Entry node : list.getChildren()) {

			if (node.getName().equals("����")) {

				final List<String> newConditions = new ArrayList<String>(conditions);
				newConditions.add(node.getAttribute("����"));

				loadBehaviors(node, newConditions);

			} else if (node.getName().equals("�s���Q��")) {
				final BehaviorBuilder behavior = new BehaviorBuilder(getConfiguration(), node, conditions);
				getNextBehaviorBuilders().add(behavior);
			}
		}
	}

	public void validate() throws ConfigurationException {
		
		if ( !getConfiguration().getActionBuilders().containsKey(getActionName()) ) {
			throw new ConfigurationException("�Ή����铮�삪���݂��܂���("+this+")");
		}
	}

	public Behavior buildBehavior() throws BehaviorInstantiationException {

		try {
			return new UserBehavior(getName(),
						getConfiguration().buildAction(getActionName(), 
								getParams()), getConfiguration() );
		} catch (final ActionInstantiationException e) {
			throw new BehaviorInstantiationException("�Ή����铮��̏������Ɏ��s���܂���("+this+")", e);
		}
	}

	
	public boolean isEffective(final VariableMap context) throws VariableException {

		for (final String condition : getConditions()) {
			if (condition != null) {
				if (!(Boolean) Variable.parse(condition).get(context)) {
					return false;
				}
			}
		}

		return true;
	}
	
	public String getName() {
		return this.name;
	}

	public int getFrequency() {
		return this.frequency;
	}

	private String getActionName() {
		return this.actionName;
	}
	
	private Map<String, String> getParams() {
		return this.params;
	}
	
	private List<String> getConditions() {
		return this.conditions;
	}
	
	private Configuration getConfiguration() {
		return this.configuration;
	}

	public boolean isNextAdditive() {
		return this.nextAdditive;
	}

	public List<BehaviorBuilder> getNextBehaviorBuilders() {
		return this.nextBehaviorBuilders;
	}
}
