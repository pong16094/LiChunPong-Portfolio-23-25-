<%-- 
    Document   : viewReservationForm
    Created on : 2025年4月21日, 下午6:29:39
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
        <h1>Hello World!</h1>

        <form action="handleReport?action=reserve" method="post">
            <label>Select Type</label>
            <select name="type">
                <option value="shop">Shop</option>
                <option value="city">City</option>
                <option value="country">Country</option>
            </select><br>

            <label>Enter ID:</label>
            <input type="number" name="id"><br>

            <input type="submit" value="View Report">
        </form>

        <form action="handleReport?action=season" method="post">
            <h2>By Season</h2>
            <label>Select Type</label>
            <select name="type">
                <option value="shop">Shop</option>
                <option value="city">City</option>
                <option value="country">Country</option>
            </select><br>


            <input type="submit" value="View Report">
        </form>
        
    </body>
</html>
