<%-- 
    Document   : manageUser
    Created on : 2025年4月19日, 下午6:28:24
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
                     ArrayList<user> users = (ArrayList<user> )request.getAttribute("users");
                    out.println("<h1>User</h1>");
                    out.println("<table border='1'               >");
                    out.println("<tr>");
                    out.println("<th>UserId</th>  <th>User Name</th><th> Password</th><th> Full Name</th> <th>Role</th> <th>CityId</th> <th>ShopId</th>");
                    out.println("</tr>");
	  // loop through the customer array to display each customer record
                    for (int i = 0; i < users.size(); i++) {
                        user c = users.get(i);
                        out.println("<tr>");

                        out.println("<td>" + c.getUserId() + "</td>");
                        out.println("<td>" + c.getUserName() + "</td>");
                        out.println("<td>" + c.getPassword() + "</td>");
                        out.println("<td>" + c.getFullName() + "</td>");
                        out.println("<td>" + c.getRole() + "</td>");
                        out.println("<td>" + c.getCityId() + "</td>");
                        out.println("<td>" + c.getShopId() + "</td>");
                        out.println("<td><a href=\"handleUser?action=delete&id=" + c.getUserId() + "\">delete</a></td>");
                        out.println("<td><a href=\"handleUser?action=getEditCustomer&id=" + c.getUserId() + "\">edit</a></td>");
                        
                        out.println("</tr>");

                    }
                    out.println("</table>");
        %>
        
    </body>
</html>
