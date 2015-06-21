package com.group_finity.mascot.config;

import java.awt.Point;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import com.group_finity.mascot.animation.Animation;
import com.group_finity.mascot.animation.Pose;
import com.group_finity.mascot.exception.AnimationInstantiationException;
import com.group_finity.mascot.exception.VariableException;
import com.group_finity.mascot.image.ImagePair;
import com.group_finity.mascot.image.ImagePairLoader;
import com.group_finity.mascot.script.Variable;

public class AnimationBuilder {

	private static final Logger log = Logger.getLogger(AnimationBuilder.class.getName());

	private final String condition;

	private final List<Pose> poses = new ArrayList<Pose>();

	public AnimationBuilder(final Entry animationNode) throws IOException {
		this.condition = animationNode.getAttribute("����") == null ? "true" : animationNode.getAttribute("����");

		log.log(Level.INFO, "�A�j���[�V�����ǂݍ��݊J�n");

		for (final Entry frameNode : animationNode.getChildren()) {

			this.getPoses().add(loadPose(frameNode));
		}

		log.log(Level.INFO, "�A�j���[�V�����ǂݍ��݊���");
	}

	private Pose loadPose(final Entry frameNode) throws IOException {

		final String imageText = frameNode.getAttribute("�摜");
		final String anchorText = frameNode.getAttribute("����W");
		final String moveText = frameNode.getAttribute("�ړ����x");
		final String durationText = frameNode.getAttribute("����");

		final String[] anchorCoordinates = anchorText.split(",");
		final Point anchor = new Point(Integer.parseInt(anchorCoordinates[0]), Integer.parseInt(anchorCoordinates[1]));

		final ImagePair image = ImagePairLoader.load(imageText, anchor);

		final String[] moveCoordinates = moveText.split(",");
		final Point move = new Point(Integer.parseInt(moveCoordinates[0]), Integer.parseInt(moveCoordinates[1]));

		final int duration = Integer.parseInt(durationText);

		final Pose pose = new Pose(image, move.x, move.y, duration);
		
		log.log(Level.INFO, "�p���ǂݍ���({0})", pose);
		
		return pose;

	}

	public Animation buildAnimation() throws AnimationInstantiationException {
		try {
			return new Animation(Variable.parse(this.getCondition()), this.getPoses().toArray(new Pose[0]));
		} catch (final VariableException e) {
			throw new AnimationInstantiationException("�����̕]���Ɏ��s���܂���", e);
		}
	}
	
	private List<Pose> getPoses() {
		return this.poses;
	}
	
	private String getCondition() {
		return this.condition;
	}
}
