<%-- 
    Document   : updateFruit
    Created on : 2025年4月16日, 下午7:46:48
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

        <h1>Update Fruit!</h1>
        <form method="post" action="bakeryUpdate?action=update">
            <%@page import="bean.*, java.util.*"%>
            <%
                ArrayList<fruit> stocks = (ArrayList<fruit>) request.getAttribute("stocks");
                out.println("<table border='1'>");

                out.println("<tr>");
                out.println("<th>Fruit Id</th>  <th>Fruit Name</th><th>Quantity</th>");
                out.println("</tr>");
                for (int i = 0; i < stocks.size(); i++) {
                    fruit c = stocks.get(i);
                    out.println("<tr>");
                    out.println("<td><input type=\"hidden\" value=\"" + c.getFruitId() + "\" name=\"id\">" + c.getFruitId() + "</td>");
                    out.println("<td><input type=\"hidden\" value=\"" + c.getName() + "\" name=\"name\">" + c.getName() + "</td>");
                    out.println("<td><input type=\"number\" name=\"qty\" value=\"" + c.getQty() + "\"></td>");
                    out.println("</tr>");
                }

                out.println("</table>");
            %>
            <input type="submit" value="update">

        </form>

    </body>
</html>
