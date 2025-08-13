/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package servlet;

import bean.location;
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

/**
 *
 * @author User
 */
@WebServlet(name = "handleRegister", urlPatterns = {"/handleRegister"})
public class handleRegister extends HttpServlet {

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
            ArrayList<location> shops = db.getShops();
            request.setAttribute("shop", shops);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/Register.jsp");
            rd.forward(request, response);
        } else if ("create".equalsIgnoreCase(action)) {
            // get parameter
            String username = request.getParameter("username");
            String password = request.getParameter("password");
            String fullName = request.getParameter("full_name");
            String role = request.getParameter("role");
            int city = Integer.parseInt(request.getParameter("city"));
            location lct;

            //lct = db.getShop(city);
            int shopId = Integer.parseInt(request.getParameter("shop"));
            if (db.addUser(username, password, fullName, role, city, shopId)) {
                response.sendRedirect("index.jsp");
            } else {
                out.print("add user fail");
            }
        } else {

            out.println("No such action!!!");

        }
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
