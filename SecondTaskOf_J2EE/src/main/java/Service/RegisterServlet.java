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

@WebServlet("/registerServlet")
public class RegisterServlet extends HttpServlet {

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        req.setCharacterEncoding("utf-8");
        resp.setCharacterEncoding("utf-8");
        Properties pro= new Properties();
        String account = req.getParameter("account");
        String username = req.getParameter("username");
        String password = req.getParameter("password");

        if(!username.isEmpty() && !password.isEmpty()){
            try {
                Connection con = JDBCUtil.getConnection();
                String sql = "select * from users where account = ?";
                String insql = "insert into users values (?, ?, ?)";

                PreparedStatement ps = con.prepareStatement(sql);
                ps.setString(1, account);

                ResultSet rs = ps.executeQuery();

                if(!rs.next()){
                    rs.close();
                    ps.close();

                    ps = con.prepareStatement(insql);
                    ps.setString(1,account);
                    ps.setString(2,username);
                    ps.setString(3, EncryptUtil.encrypt(password));


                    resp.sendRedirect("/successfulRegister.jsp");

                }else {
                    resp.sendRedirect("/failExist.jsp");
                }
                JDBCUtil.release(con,ps,rs);

            }catch (IOException e){
                e.printStackTrace();
            } catch (SQLException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }


        }else {
            resp.sendRedirect("/failEmpty.jsp");
        }


    }
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        doPost(req,resp);
    }
}
