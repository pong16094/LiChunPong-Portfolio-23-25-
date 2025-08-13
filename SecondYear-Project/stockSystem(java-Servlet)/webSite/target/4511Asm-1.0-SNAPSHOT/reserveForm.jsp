<%-- 
    Document   : reserveForm
    Created on : 2025年4月15日, 下午3:03:10
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
        <h2>Reserve Fruits from Source City</h2>
    <form action="handleReserve" method="post">
        <input type="hidden" value="order" name="action">
        <%@page import="bean.*, java.util.*"%>
         <%
                     ArrayList<fruit> fruits = (ArrayList<fruit> )request.getAttribute("fruits");
                    out.println("<table border='1'>");
                    out.println("<tr>");
                        out.println("<th>Fruit Name</th>  <th>Source City</th><th> Quantity</th>");
                    out.println("</tr>");
                    for (int i = 0; i < fruits.size(); i++) {
                        fruit c = fruits.get(i);
                        out.println("<tr>");
                        out.println("<td><input type=\"hidden\" value=\""+c.getFruitId()+"\" name=\"fruitId\">" + c.getName() + "</td>");
                        out.println("<td>" + c.getCity() + "</td>");
                        out.println("<td> <input type=\"number\" name=\"quantity\" value=\"0\" min=\"0\"></td>");                        
                        out.println("</tr>");
                    }
                    out.println("</table>");
        %>
        
        <input type="submit" value="Reserve">
    </form>
    </body>
</html>
