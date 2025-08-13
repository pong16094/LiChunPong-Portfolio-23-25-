<%-- 
    Document   : warehousePage
    Created on : 2025年4月11日, 下午10:17:43
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


        <a href="bakeryUpdate?action=list">Stocks</a><br>
        <a href="handleWarehouse?action=list">all rev</a>(only source warehouse)<br>
        <a href="handleWarehouse?action=send">approve</a>(only source warehouse)<br>
        <a href="handleWarehouse?action=listArrive">arrive</a>(only central warehouse)<br>


    </body>
</html>
