/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package servlet;

import bean.fruit;
import bean.reservation;
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
@WebServlet(name = "handleReport", urlPatterns = {"/handleReport"})
public class handleReport extends HttpServlet {

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

        if ("reserve".equalsIgnoreCase(action)) {
            String type = request.getParameter("type");
            String id = request.getParameter("id");
            ArrayList<reservation> reservations = null;
            reservations = db.getByType(type);

            request.setAttribute("reservations", reservations);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/reserveView.jsp");
            rd.forward(request, response);
        } else if ("season".equalsIgnoreCase(action)) {
            String type = request.getParameter("type");
            ArrayList<reservation> reservations = null;
            reservations = db.getBySeason(type);

            request.setAttribute("reservations", reservations);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/reserveView.jsp");
            rd.forward(request, response);
        } else if ("getEditCustomer".equalsIgnoreCase(action)) {
            String id = request.getParameter("id");
            // obtain the parameter id;
            if (id != null) {
                // call  query db to get retrieve for a customer with the given id
                fruit fruit = db.getFruitById(id);

                request.setAttribute("fruit", fruit);
                // forward the result to the editCustomer.jsp   
                RequestDispatcher rd;
                rd = getServletContext().getRequestDispatcher("/editFruit.jsp");
                rd.forward(request, response);
            }
        } else if ("edit".equalsIgnoreCase(action)) {
            int id = Integer.parseInt(request.getParameter("id"));
            String name = request.getParameter("name");
            String country = request.getParameter("country");
            fruit fruit = new fruit(id, name, country);
            System.out.print(fruit);
            db.editFruit(fruit);

            response.sendRedirect("handleFruit?action=list");

        } else if ("add".equalsIgnoreCase(action)) {
            String name = request.getParameter("name");
            String country = request.getParameter("country");
            db.addFruit(name, country);

            // redirect the result to the listCustomers.jsp
            response.sendRedirect("handleFruit?action=list");
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
