<%--
  Created by IntelliJ IDEA.
  User: GK
  Date: 2019/10/15
  Time: 17:45
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>注册页面</title>
    <script>
        function jump(){
            window.location.href="login.jsp";
        }
    </script>
</head>
<body>
<div align="center">
    <form action="${pageContext.request.contextPath}/registerServlet" method="post">
        <div class="">
            <label id="l_username">用户名：</label>
            <input type="text" id="username" name="username" placeholder="请输入用户名" >
        </div><br>

        <div class="">
            <label id="l_account">账号：</label>
            <input type="text" id="account" name="account" placeholder="请输入账号" >
        </div><br>

        <div class="">
            <label id="l_password">密码：</label>
            <input type="password" id="password" name="password" placeholder="请输入密码" >
        </div><br>

        <div class="">
            <input type="button" value="返回登陆" onclick="jump()" /> &nbsp;
            <input type="reset"  value="重置" />  &nbsp;
            <input type="submit" value="注册" />
        </div>
    </form>

</div>

</body>
</html>
