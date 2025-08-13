<%-- 
    Document   : arrive
    Created on : 2025年4月18日, 下午11:12:00
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
        <form method="post" action="handleWarehouse?action=end">
            <%@page import="bean.*, java.util.*"%>
            <%
                ArrayList<reservation> reservations = (ArrayList<reservation>) request.getAttribute("reservation");
                out.println("<table border='1'>");
                out.println("<tr>");
                out.println("<th></th><th>Form Country</th><th>Send Shop Id</th><th>Fruit Name</th><th>Quantity</th><th>Send Date</th>");
                out.println("</tr>");
                for (int i = 0; i < reservations.size(); i++) {
                    reservation c = reservations.get(i);
                    out.println("<tr>");
                    out.println("<td> <input type=\"checkbox\" name=\"id\" value=\"" + c.getFruitId() + "\">");
                    out.println("<input type=\"hidden\" name=\"toId\" value=\"" + c.getLocationId() + "\">");//the shop Id
                    out.println("<input type=\"hidden\" name=\"qty\" value=\"" + c.getQty() + "\"> </td>");
                    out.println("<input type=\"hidden\" name=\"date\" value=\"" + c.getDate() + "\">");

                    out.println("<td>" + c.getCountry() + "</td>");//the country send
                    out.println("<td>" + c.getLocationId() + "</td>");//the shop id
                    out.println("<td>" + c.getName() + "</td>");
                    out.println("<td>" + c.getQty() + "</td>");
                    out.println("<td>" + c.getDate() + "</td>");
                    out.println("</tr>");
                }
                out.println("</table>");
            %>
            <input type="submit" value="Approve">
        </form>
    </body>
</html>
