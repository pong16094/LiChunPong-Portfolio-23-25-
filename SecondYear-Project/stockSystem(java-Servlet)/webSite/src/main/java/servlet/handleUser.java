/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package servlet;

import bean.fruit;
import bean.location;
import bean.reservation;
import bean.user;
import db.UserDb;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author User
 */
@WebServlet(name = "handleUser", urlPatterns = {"/handleUser"})
public class handleUser extends HttpServlet {

    private UserDb db;

    @Override
    public void init() {
        String dbUser = this.getServletContext().getInitParameter("dbUser");
        String dbPassword = this.getServletContext().getInitParameter("dbPassword");
        String dbUrl = this.getServletContext().getInitParameter("dbUrl");
        db = new UserDb(dbUrl, dbUser, dbPassword);
    }

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String action = request.getParameter("action");
        System.out.println("Processing request: action = " + action);
        PrintWriter out = response.getWriter();

        if ("list".equalsIgnoreCase(action)) {
            ArrayList<user> users = db.getUser();
            request.setAttribute("users", users);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/manageUser.jsp");
            rd.forward(request, response);
        } else if ("delete".equalsIgnoreCase(action)) {
            // get parameter, id, from the request
            String id = request.getParameter("id");
            if (id != null) {
                // call delete record method in the database
                db.delRecord(id);
                // redirect the result to list action 
                response.sendRedirect("handleUser?action=list");
            }
        } else if ("getEditCustomer".equalsIgnoreCase(action)) {
            String id = request.getParameter("id");
            // obtain the parameter id;
            if (id != null) {
                // call  query db to get retrieve for a customer with the given id
                user user = db.getUserById(id);
                ArrayList<location> location = db.getShops();
                // set the customer as attribute in request scope
                request.setAttribute("c", user);
                request.setAttribute("location", location);
                // forward the result to the editCustomer.jsp   
                RequestDispatcher rd;
                rd = getServletContext().getRequestDispatcher("/editUser.jsp");
                rd.forward(request, response);
            }
        } else if ("addNewUser".equalsIgnoreCase(action)) {
            ArrayList<location> location = db.getShops();
            // set the customer as attribute in request scope
            request.setAttribute("location", location);
            // forward the result to the editCustomer.jsp   
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/editUser.jsp");
            rd.forward(request, response);
        } else if ("edit".equalsIgnoreCase(action)) {
            int userId = Integer.parseInt(request.getParameter("userId"));
            String userName = request.getParameter("userName");
            String password = request.getParameter("password");
            String fullName = request.getParameter("fullName");
            String role = request.getParameter("role");
            int cityId = Integer.parseInt(request.getParameter("cityId"));
            int shopId = Integer.parseInt(request.getParameter("shopId"));
            user user = new user(userId, shopId, cityId, role, userName, password, fullName);
            System.out.print(user);
            db.editRecord(user);

            response.sendRedirect("handleUser?action=list");
        } else if ("add".equalsIgnoreCase(action)) {
            String userName = request.getParameter("userName");
            String password = request.getParameter("password");
            String fullName = request.getParameter("fullName");
            String role = request.getParameter("role");
            int cityId = Integer.parseInt(request.getParameter("cityId"));
            int shopId = Integer.parseInt(request.getParameter("shopId"));
            db.addUser(userName, password, fullName, role, cityId, shopId);

            // redirect the result to the listCustomers.jsp
            response.sendRedirect("handleUser?action=list");
        } else {
            out.println("No such action!!!");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
