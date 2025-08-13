<%-- 
    Document   : editFruit
    Created on : 2025年4月21日, 下午5:34:45
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
        <jsp:useBean id="fruit" scope ="request" class="bean.fruit"/>
<% String type = (fruit != null && fruit.getFruitId()!= 0) ? "edit" : "add"; %>

<form  method=“get" action="handleFruit?action=<%=type%>">

    <% String name = fruit.getName() != null ? fruit.getName() : ""; %>
    <% String country = fruit.getCity() != null ? fruit.getCity() : ""; %>


    <input type="hidden" name="action"  value="<%= type%>"/>

    <%
        if( fruit != null && fruit.getFruitId() != 0){
            out.println("FruitId: "+fruit.getFruitId()+"<input name=\"id\"  type=\"hidden\" value=\""+fruit.getFruitId()+"\"/><br>");
        }
    %>
    Fruit<input name="name"  type="text" value="<%= name%>"/> <br>
    Source country<input name="country"  type="text" value="<%= country%>"/> <br>


    <td ><input type="submit" value="submit"/> <br>
</form>
    </body>
</html>
