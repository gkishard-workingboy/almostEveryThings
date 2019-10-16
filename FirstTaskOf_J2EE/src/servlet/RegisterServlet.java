package servlet;


import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.*;
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
        String username = req.getParameter("username");
        String password = req.getParameter("password");

        if(!username.isEmpty() && !password.isEmpty()){
            try {
                InputStreamReader isr = new InputStreamReader(RegisterServlet.class.getClassLoader().getResourceAsStream("loginList.properties"),"utf-8");
                pro.load(isr);

                isr.close();
                String returnKey = pro.getProperty(username);

                if(returnKey == null){

                    //pro.clear();
                    pro.setProperty(username,password);
                    File f= new File( RegisterServlet.class.getClassLoader().getResource("/").getPath()+"loginList.properties");
                    FileOutputStream fos = new FileOutputStream(f,false);


                    pro.store(fos ,null);
                    fos.flush();

                    fos.close();

                    resp.sendRedirect("/successfulRegister.jsp");
                }else {
                    resp.sendRedirect("/failExist.jsp");
                }

            }catch (IOException e){
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
