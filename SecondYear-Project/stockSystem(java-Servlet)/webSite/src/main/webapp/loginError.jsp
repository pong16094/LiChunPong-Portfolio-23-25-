<%-- 
    Document   : loginError
    Created on : Mar 17, 2025, 3:16:45 PM
    Author     : a1
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <p>Incorrect Password</p>
        <p>
            <% out.println("<a href=\""+ request.getContextPath()+ "\">Login again</a>");%>
        </p>
    </body>
</html>
