<%-- 
    Document   : totalNeeds
    Created on : 2025年4月17日, 下午8:16:06
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
        <h1>Total Needs!</h1>
        <form method="post" action="handleWarehouse?action=confirm">
            <%@page import="bean.*, java.util.*"%>
            <%
                ArrayList<reservation> reservations = (ArrayList<reservation>) request.getAttribute("reservation");
                out.println("<table border='1'>");
                out.println("<tr>");
                out.println("<th></th><th>Country</th><th>Fruit Name</th><th>Quantity</th>");
                out.println("</tr>");
                for (int i = 0; i < reservations.size(); i++) {
                    reservation c = reservations.get(i);
                    out.println("<tr>");
                    out.println("<td> <input type=\"checkbox\" name=\"id\" value=\""+ c.getFruitId() +"\"> </td>");
                    out.println("<td>" + c.getCountry() + "</td>");
                    out.println("<td>" + c.getName() + "</td>");
                    out.println("<td>" + c.getQty() + "</td>");
                    out.println("</tr>");
                }
                out.println("</table>");
            %>


            <input type="submit" value="Approve ">
        </form>

    </body>
</html>
