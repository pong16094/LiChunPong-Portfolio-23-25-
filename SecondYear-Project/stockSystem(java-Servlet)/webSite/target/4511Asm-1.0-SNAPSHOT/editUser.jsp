
<%@page import="bean.location"%>
<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>JSP Page</title>
</head>
<body>
<h1>Hello World!</h1>

<jsp:useBean id="c" scope ="request" class="bean.user"/>
<% String type = (c != null && c.getUserId() != 0) ? "edit" : "add"; %>

<form  method=“get" action="handleUser?action=<%=type%>">

    <% String password = c.getPassword() != null ? c.getPassword() : ""; %>
    <% String userName = c.getUserName() != null ? c.getUserName() : ""; %>
    <% String fullName = c.getFullName() != null ? c.getFullName() : ""; %>
    <% String role = c.getRole() != null ? c.getRole() : "";%>

    <input type="hidden" name="action"  value="<%= type%>"/>

    <%
        if( c != null && c.getUserId() != 0){
            out.println("userId:"+c.getUserId()+"<input name=\"userId\"  type=\"hidden\" value=\""+c.getUserId()+"\"/><br>");
        }
    %>
    userName<input name="userName"  type="text" value="<%= userName%>"/> <br>
    password<input name="password"  type="text" value="<%= password%>"/> <br>
    fullName<input name="fullName"  type="text" value="<%= fullName%>"/> <br>
Role 
    <select name="role">
        <option value="">-- Select Role --</option>
        <option value="Bakery" <%= c != null && "Bakery".equals(c.getRole()) ? "selected" : ""%>>Bakery Staff</option>
        <option value="Warehouse" <%= c != null && "Warehouse".equals(c.getRole()) ? "selected" : ""%>>Warehouse Staff</option>
        <option value="SeniorManagement" <%= c != null && "SeniorManagement".equals(c.getRole()) ? "selected" : ""%>>Senior Management</option>
    </select><br>

    cityId
    <%
        ArrayList<location> customers = (ArrayList<location>) request.getAttribute("location");

        out.println("<select name=\"cityId\">");
        out.println("<option value=\"\">-- City --</option>");
        ArrayList<location> copy = new ArrayList<location>();

        // loop through the customer array to display each customer record
        for (location p : customers) {
            boolean alreadyExists = false;

            // Check if this name is already in uniqueList
            for (location up : copy) {
                if (up.getCity().equals(p.getCity())) {
                    alreadyExists = true;
                    break;
                }
            }

            // Only add if not already in the list
            if (!alreadyExists) {
                copy.add(p);
            }
        }

        for (int i = 0; i < copy.size(); i++) {
            location l = copy.get(i);
            out.print("<option value=\"" + l.getCityId() + "\"");
            if (c.getCityId() == l.getCityId()) {
                out.print("selected");
            }
            out.println(">" + l.getCity() + "</option>");
        }
        out.println("</select>");
    %>

    <br>
    ShopId
    <%
        out.println("<select name=\"shopId\">");
        out.println("<option value=\"\">-- Location --</option>");
        // loop through the customer array to display each customer record
        for (int i = 0; i < customers.size(); i++) {
            location l = customers.get(i);
            out.print("<option value=\"" + l.getLocationId() + "\"");
            if (c.getShopId() == l.getLocationId()) {
                out.print("selected");
            }
            out.println(">" + l.getLocationName() + "</option>");
        }
        out.println("</select>");
    %>
    <br>
    <td ><input type="submit" value="submit"/> <br>
</form>
</body>
</html>

