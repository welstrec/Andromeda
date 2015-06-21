package com.group_finity.mascot.image;


/**
 * �}�X�R�b�g�摜�̍��E�����̃y�A.
 * 
 * �}�X�R�b�g�̉摜�͍��E�����ɊǗ��ł���Ɠs�����ǂ�.
 */
public class ImagePair {

	/**
	 * ���������Ă���摜.
	 */
	private MascotImage leftImage;

	/**
	 * �E�������Ă���摜.
	 */
	private MascotImage rightImage;

	/**
	 * �����̓�̉摜����摜�y�A���쐬����.
	 * @param leftImage�@���������Ă���摜.
	 * @param rightImage �E�������Ă���摜.
	 */
	public ImagePair(
			final MascotImage leftImage, final MascotImage rightImage) {
		this.leftImage = leftImage;
		this.rightImage = rightImage;
	}

	/**
	 * �w�肵���������������摜���擾����.
	 * @param lookRight �E�����̉摜���擾���邩�ǂ���.
	 * @return �w�肵�������������Ă���摜.
	 */
	public MascotImage getImage(final boolean lookRight) {
		return lookRight ? this.getRightImage() : this.getLeftImage();
	}

	private MascotImage getLeftImage() {
		return this.leftImage;
	}
	
	private MascotImage getRightImage() {
		return this.rightImage;
	}
}
