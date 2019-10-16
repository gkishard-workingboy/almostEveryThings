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

@WebServlet("/loginServlet")
public class LoginServlet extends HttpServlet {

    private static Properties pro= new Properties();


    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        req.setCharacterEncoding("utf-8");
        resp.setCharacterEncoding("utf-8");

        String username = req.getParameter("username");
        String password = req.getParameter("password");

        if(!username.isEmpty() && !password.isEmpty()){
            InputStreamReader isr = new InputStreamReader(LoginServlet.class.getClassLoader().getResourceAsStream("loginList.properties"),"utf-8");
           try {

               pro.load(isr);

               String returnKey = pro.getProperty(username);


               if(returnKey == null){
                   resp.sendRedirect("/failNoneExist.jsp");
               }else if(password.equals(returnKey)){
                    req.setAttribute("username",username);
                    req.getRequestDispatcher("/successfulLogin.jsp").forward(req,resp);
               }else{
                   resp.sendRedirect("/failWrong.jsp");
               }



           }catch (IOException e){
               e.printStackTrace();
           }catch (NullPointerException e){
               e.printStackTrace();
           }finally {
               isr.close();
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
