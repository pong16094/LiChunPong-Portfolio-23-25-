<%-- 
    Document   : bakeryPage
    Created on : 2025年4月11日, 下午10:17:19
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
        <h1>Bakery!</h1>
        <a href="handleReserve?action=list">Reserve Fruits</a><br>
        <a href="handleReserve?action=record">Reserve Record</a><br>
        <a href="bakeryUpdate?action=list">Stocks</a><br>
        <a href="bakeryUpdate?action=borrow">borrow</a><br>
        

    </body>
</html>
