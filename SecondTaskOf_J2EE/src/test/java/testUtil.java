import Util.EncryptUtil;
import Util.JDBCUtil;
import org.junit.Test;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

/**
 * SecondTaskOf_J2EE
 *
 * @Author by  GK
 * 2019--十一月--03
 */
public class testUtil {

	@Test
	public void test01() throws Exception {
		Connection con = JDBCUtil.getConnection();
		String sql = "select * from users";
		PreparedStatement psta = con.prepareStatement(sql);
		ResultSet rs = psta.executeQuery();//返回结果集ResultSet
		while (rs.next()) {
			String account = rs.getString(1);// 获取第一个列的值
			String username = rs.getString(2);// 获取第二个列的值
			String password = rs.getString(3);// 获取第三列的值

			System.out.println("account=" + account + " username=" + username
					+ " password=" + password);
			System.out.println("................................................");
			System.out.println("Encrypted password: " + EncryptUtil.encrypt(password));
		}
	}

	@Test
	public void test02() throws Exception {
		Connection con = JDBCUtil.getConnection();
		String sql = "insert into users values (?,?,?)";
		PreparedStatement ps = con.prepareStatement(sql);
		ps.setString(1, "111");
		ps.setString(2, "魏志宽");
		ps.setString(3, EncryptUtil.encrypt("123456"));
		ps.executeUpdate();
	}
}
