    <%-- 
    Document   : borrow
    Created on : 2025年4月16日, 下午8:50:14
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
        <%@page import="bean.*, java.util.*"%>
        <%//show current shop stock
            ArrayList<fruit> stocks = (ArrayList<fruit>) request.getAttribute("shop");
            out.println("<table border='1'>");

            out.println("<tr>");
            out.println("<th>Fruit Id</th>  <th>Fruit Name</th><th>Quantity</th>");
            out.println("</tr>");
            for (int i = 0; i < stocks.size(); i++) {
                fruit c = stocks.get(i);
                out.println("<tr>");
                out.println("<td>" + c.getFruitId() + "</td>");
                out.println("<td>" + c.getName() + "</td>");
                out.println("<td>" + c.getQty() + "</td>");
                out.println("</tr>");
            }

            out.println("</table>");
        %>

        <%//selection 
            
            ArrayList<location> shop = (ArrayList<location>) request.getAttribute("allSC");
            out.println("<form method=\"post\" action=\"bakeryUpdate?action=borrow\">");
            out.println("<select name=\"shopId\">");
            out.println("<option value=\"\">-- Shop --</option>");
            // loop through the customer array to display each customer record
            for (int i = 0; i < shop.size(); i++) {
                location c = shop.get(i);
                out.println("<option value=\"" + c.getLocationId() + "\" >" + c.getLocationId()+"--"+ c.getLocationName() + "</option>");
            }
            out.println("<select>");
            out.println("<input type=\"submit\" value=\"show\">");
            out.println("</form>");
            
        %>
        <% 
         int shopId = (int)request.getAttribute("otherShopId");
         out.println("<h3>"+shopId+"</h3>");
        %>
        <form method="post" action="bakeryUpdate?action=doBorrow">
        <%//show anothe shop stock
            ArrayList<fruit> other = (ArrayList<fruit>) request.getAttribute("other");
            out.println("<input type=\"hidden\" value=\"" + shopId + "\" name=\"borrowShopId\">");
            out.println("<table border='1'>");

            out.println("<tr>");
            out.println("<th>Fruit Id</th>  <th>Fruit Name</th><th>Stock Quantity</th><th>Quantity</th>");
            out.println("</tr>");
            for (int i = 0; i < other.size(); i++) {
                fruit c = other.get(i);
                out.println("<tr>");
                out.println("<td><input type=\"hidden\" value=\"" + c.getFruitId() + "\" name=\"id\">" + c.getFruitId() + "</td>");
                out.println("<td>" + c.getName() + "</td>");
                out.println("<td>" + c.getQty() + "</td>");
                out.println("<td><input type=\"number\" name=\"qty\" value=\"0\" min=\"0\" max=\""+ c.getQty() + "\"></td>");
                out.println("</tr>");
            }

            out.println("</table>");
        %>

        <input type="submit" value="Borrow">
        </form>
    </body>
</html>
