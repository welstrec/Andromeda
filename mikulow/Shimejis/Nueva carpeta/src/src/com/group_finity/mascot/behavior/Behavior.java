package com.group_finity.mascot.behavior;

import java.awt.event.MouseEvent;

import com.group_finity.mascot.Mascot;
import com.group_finity.mascot.exception.CantBeAliveException;


/**
 * �}�X�R�b�g�̒����I�ȐU�镑��������킷�I�u�W�F�N�g.
 * 
 * {@link Mascot#setBehavior(Behavior)} �Ŏg�p����.
 */
public interface Behavior {

	/**
	 * �s�����J�n���鎞�ɌĂяo��.
	 * @param mascot �֘A�t����}�X�R�b�g.
	 */
	public void init(Mascot mascot) throws CantBeAliveException;

	/**
	 * �}�X�R�b�g�����̃R�}�ɐi�߂�.
	 */
	public void next() throws CantBeAliveException;
	
	/**
	 * �}�E�X�{�^���������ꂽ.
	 * @param mascot �}�E�X�N���b�N���ꂽ�}�X�R�b�g.
	 */
	public void mousePressed(MouseEvent e) throws CantBeAliveException;

	/**
	 * �}�E�X�������ꂽ.
	 * @param mascot �}�E�X�������ꂽ�}�X�R�b�g.
	 */
	public void mouseReleased(MouseEvent e) throws CantBeAliveException;
}
