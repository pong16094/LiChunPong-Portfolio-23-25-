<%-- 
    Document   : Register
    Created on : 2025年4月15日, 上午8:29:12
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
        <div class="register-form">
            <h2>Register</h2>
            <form method="POST" action="handleRegister">
                <input type="hidden" value="create" name="action">
                <div >
                    <label>Username</label>
                    <input type="text" name="username" required />
                </div>

                <div >
                    <label>Password</label>
                    <input type="password" name="password" required />
                </div>

                <div >
                    <label>Full Name</label>
                    <input type="text" name="full_name" required />
                </div>

                <div >
                    <label>Role</label>
                    <select name="role" required>
                        <option value="">-- Select Role --</option>
                        <option value="Bakery">Bakery Staff</option>
                        <option value="Warehouse">Warehouse Staff</option>
                    </select>
                </div>

                <div>
                    <label>Work city</label>

                    <%@page import="bean.*, java.util.*"%>
                    <%
                        ArrayList<location> city = (ArrayList<location>) request.getAttribute("shop");
                        ArrayList<location> copy = new ArrayList<location>();
                        out.println("<select name=\"city\">");
                        out.println("<option value=\"\">-- Shop --</option>");
                        for (location p : city) {
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
                            location c = copy.get(i);

                            out.println("<option value=\"" + c.getCityId() + "\">" + c.getCity() + "</option>");
                            System.out.println(c);
                        }
                        out.println("<select>");
                    %>
                </div>
                <div>
                    <label>Shop</label>

                    <%
                        ArrayList<location> customers = (ArrayList<location>) request.getAttribute("shop");
                        out.println("<select name=\"shop\">");
                        out.println("<option value=\"\">-- Shop --</option>");
                        // loop through the customer array to display each customer record
                        for (int i = 0; i < customers.size(); i++) {
                            location c = customers.get(i);

                            out.println("<option value=\"" + c.getLocationId() + "\">" + c.getLocationName() + "</option>");

                        }
                        out.println("<select>");
                    %>
                </div>

                <div>
                    <button type="submit">Register</button>
                </div>
            </form>
        </div>
    </body>
</html>
