package Service;


import Util.EncryptUtil;
import Util.JDBCUtil;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.*;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Properties;

/**
 * FileHeader
 * Author by: GK
 * In 2019-五月-07
 * DOC:
 */

@WebServlet("/loginServlet")
public class LoginServlet extends HttpServlet {

	private static Properties pro = new Properties();


	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		req.setCharacterEncoding("utf-8");
		resp.setCharacterEncoding("utf-8");

		String account = req.getParameter("account");
		String password = req.getParameter("password");

		if (!account.isEmpty() && !password.isEmpty()) {

			Connection con = JDBCUtil.getConnection();
			String sql = "select * from users where account = ?";
			try {
				PreparedStatement ps = con.prepareStatement(sql);
				ps.setString(1, account);

				ResultSet rs = ps.executeQuery();

				if (rs.next()) {

					String username = rs.getString(2);
					String pw = rs.getString(3);

					if (EncryptUtil.encrypt(password).equals(pw)) {
						req.setAttribute("username", username);
						req.getRequestDispatcher("/successfulLogin.jsp").forward(req, resp);
					} else {
						resp.sendRedirect("/failWrong.jsp");
					}


				} else {
					resp.sendRedirect("/failNoneExist.jsp");

				}

				JDBCUtil.release(con,ps,rs);

			} catch (SQLException e) {
				e.printStackTrace();
			} catch (Exception e) {
				e.printStackTrace();
			}


		} else {
			resp.sendRedirect("/failEmpty.jsp");
		}


	}

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		doPost(req, resp);
	}
}
