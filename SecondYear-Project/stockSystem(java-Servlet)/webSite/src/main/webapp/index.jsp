<%-- 
    Document   : index
    Created on : 2025年4月11日, 下午8:59:30
    Author     : User
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
    </head>
    <body>
        <h1>Login Page</h1>
        
        <form method="post" action="login">
            <input type="hidden" name="action" value="authenticate"/>
            <div>username</div>
            <div><input type="text" name="username" ></div>
            <div>password</div>
            <div><input type="password" name="password"></div>
            <div><input type="submit" value="Login"></div>
        </form>
        <a href="handleRegister?action=list">Register</a><br>
    </body>
</html>
