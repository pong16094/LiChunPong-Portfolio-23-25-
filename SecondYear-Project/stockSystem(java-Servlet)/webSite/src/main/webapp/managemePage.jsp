<%-- 
    Document   : managemePage
    Created on : 2025年4月11日, 下午10:18:01
    Author     : User
--%>    

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form method="post" action="login">
            <input type="hidden" name="action" value="logout">
            <input type="submit" value="Logout" name="logoutButton">       
        </form>
        <h1>This is management Page!</h1>

        <a href="handleUser?action=list">List user</a><br>
        <a href="handleUser?action=addNewUser">Add user</a><br>
        <a href="handleFruit?action=list">Update fruit</a><br>
        <a href="editFruit.jsp">Add fruit</a><br>
        <a href="viewReservationForm.jsp">Add fruit</a><br>

    </body>
</html>
