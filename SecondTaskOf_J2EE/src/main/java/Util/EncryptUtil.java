package Util;

import sun.misc.BASE64Encoder;

import java.security.MessageDigest;

/**
 * SecondTaskOf_J2EE
 *
 * @Author by  GK
 * 2019--十一月--03
 */
public class EncryptUtil {
	public static String encrypt(String pwd ) throws Exception {
		MessageDigest md5 = MessageDigest.getInstance("MD5");

		BASE64Encoder be = new BASE64Encoder();
		return be.encode(md5.digest(pwd.getBytes("utf-8")));

	}

}
