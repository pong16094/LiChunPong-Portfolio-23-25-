<%-- 
    Document   : checkRecord
    Created on : 2025年4月15日, 下午7:35:22
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
        <h1><a href="bakeryPage.jsp">Home Page</a></h1>
        <h1>Check Record!</h1>
        
        <%@page import="bean.*, java.util.*"%>
         <%
                     ArrayList<reservation> records = (ArrayList<reservation> )request.getAttribute("records");
                    out.println("<table border='1'>");
                    out.println("<tr>");
                        out.println("<th>Fruit Name</th>  <th>Quantity</th><th>Date</th><th>Status</th>");
                    out.println("</tr>");
                    for (int i = 0; i < records.size(); i++) {
                        reservation c = records.get(i);
                        out.println("<tr>");
                        out.println("<td>" + c.getName() + "</td>");
                        out.println("<td>" + c.getQty() + "</td>");
                        out.println("<td> "+c.getDate()+"</td>");                        
                        out.println("<td> "+c.getStatus()+"</td>");                        
                        out.println("</tr>");
                    }
                    out.println("</table>");
        %>
    </body>
</html>
