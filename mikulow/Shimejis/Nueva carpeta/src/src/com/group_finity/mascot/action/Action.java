package com.group_finity.mascot.action;

import com.group_finity.mascot.Mascot;
import com.group_finity.mascot.exception.LostGroundException;
import com.group_finity.mascot.exception.VariableException;

/**
 * �}�X�R�b�g�̃A�j���[�V����������킷�I�u�W�F�N�g.
 * 
 * ��莞�Ԓu���� {@link #next(Mascot)} ���Ăяo�����
 */
public interface Action {

	/**
	 * �A�N�V�������J�n���鎞�ɌĂяo��.
	 * @param mascot �֘A�t����}�X�R�b�g.
	 */
	public void init(Mascot mascot) throws VariableException;

	/**
	 * ���̃t���[�������邩�ǂ������ׂ�.
	 * @return ���̃t���[�������邩�ǂ���.
	 */
	public boolean hasNext() throws VariableException;
	
	/**
	 * �}�X�R�b�g�����̃R�}�ɐi�߂�.
	 * @throws LostGroundException �n�ʂ��Ȃ�.
	 */
	public void next() throws LostGroundException, VariableException;
	
}
