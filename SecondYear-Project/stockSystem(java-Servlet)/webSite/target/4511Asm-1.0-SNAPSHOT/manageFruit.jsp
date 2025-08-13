<%-- 
    Document   : manageFruit
    Created on : 2025年4月21日, 下午5:04:30
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
        <h1><a href="managemePage.jsp">Home</a></h1>
        <%@page import="bean.*, java.util.*"%>
        <%
            ArrayList<fruit> fruits = (ArrayList<fruit>) request.getAttribute("fruit");
            out.println("<h1>Fruit</h1>");
            out.println("<table border='1'>");
            out.println("<tr>");
            out.println("<th>FruitI</th> <th>Fruit</th><th> Source country</th>");
            out.println("</tr>");
            // loop through the customer array to display each customer record
            for (int i = 0; i < fruits.size(); i++) {
                fruit c = fruits.get(i);
                out.println("<tr>");

                out.println("<td>" + c.getFruitId() + "</td>");
                out.println("<td>" + c.getName()+ "</td>");
                out.println("<td>" + c.getCity() + "</td>");

                out.println("<td><a href=\"handleFruit?action=delete&id=" + c.getFruitId() + "\">delete</a></td>");
                out.println("<td><a href=\"handleFruit?action=getEditCustomer&id=" + c.getFruitId() + "\">edit</a></td>");

                out.println("</tr>");

            }
            out.println("</table>");
        %>


    </body>
</html>
