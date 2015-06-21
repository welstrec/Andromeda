package com.group_finity.mascot;

import java.awt.image.BufferedImage;

import javax.swing.JOptionPane;

import com.group_finity.mascot.environment.Environment;
import com.group_finity.mascot.image.NativeImage;
import com.group_finity.mascot.image.TranslucentWindow;
import com.sun.jna.Platform;

public abstract class NativeFactory {

	private static final NativeFactory instance;

	static {
		String subpkg = "generic";

		if ( Platform.isWindows() ) {
			subpkg = "win";
		}

		String basepkg = NativeFactory.class.getName();
		// クラス名を削除
		basepkg = basepkg.substring(0, basepkg.lastIndexOf('.'));

		try {
			final Class<? extends NativeFactory> impl = (Class<? extends NativeFactory>)Class.forName(basepkg+"."+subpkg+".NativeFactoryImpl");

			instance = impl.newInstance();

		} catch (final ClassNotFoundException e) {
			throw new RuntimeException(e);
		} catch (final InstantiationException e) {
			throw new RuntimeException(e);
		} catch (final IllegalAccessException e) {
			throw new RuntimeException(e);
		}
	}

	public static NativeFactory getInstance() {
		return instance;
	}

	public abstract Environment getEnvironment();

	public abstract NativeImage newNativeImage(BufferedImage src);

	public abstract TranslucentWindow newTransparentWindow();
}
