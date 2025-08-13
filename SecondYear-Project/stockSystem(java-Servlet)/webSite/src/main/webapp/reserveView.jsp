<%-- 
    Document   : reserveView
    Created on : 2025年4月21日, 下午6:26:26
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
        <%@page import="bean.*, java.util.*"%>
        <%
            ArrayList<reservation> report = (ArrayList<reservation>) request.getAttribute("reservations");

        %>
        
        <h2>Reservation Report</h2>
<table border="1">
    <tr><th>Location Id</th><th>Location Name</th><th>Fruit Id</th><th>Fruit</th><th>Total needs</th></tr>
<%
    for (reservation r : report) {
%>
    <tr>
        
        <td><%= r.getLocationId()%></td>
        <td><%= r.getCountry()%></td>
        <td><%= r.getFruitId()%></td>
        <td><%= r.getName() %></td>
        <% if(r.getSeason()!=null){
                out.print("<td>"+r.getSeason() +"</td>");
            }
            %>
        <td><%= r.getQty() %></td>
    </tr>
<%
    }
%>
</table>

    </body>
</html>
