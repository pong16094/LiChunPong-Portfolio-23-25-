/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package servlet;

import bean.fruit;
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
@WebServlet(name = "handleWarehouse", urlPatterns = {"/handleWarehouse"})
public class handleWarehouse extends HttpServlet {

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

        HttpSession session = request.getSession();
        user info = (user) session.getAttribute("userInfo");
        int city = info.getCityId();
        System.out.println("****Here is servlet****" + city);
        int locationId = info.getShopId();

        if ("list".equalsIgnoreCase(action)) {//list all reverstion last 14 day by country
            ArrayList<reservation> reservation = db.getReservation(city, locationId);// only get the reservation in your country
            if (reservation == null) {
                response.sendRedirect("warehouseErrorPage.jsp");
                return;
            }
            request.setAttribute("reservation", reservation);

            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/totalNeeds.jsp");
            rd.forward(request, response);
        } else if ("confirm".equalsIgnoreCase(action)) {
            String[] fruitsId = request.getParameterValues("id");
            if (!db.cfReservation(fruitsId)) {//update the reservation
                return;
            }
            response.sendRedirect("warehousePage.jsp");
        } else if ("send".equalsIgnoreCase(action)) {
            ArrayList<reservation> approved = db.getApproved(city, locationId);// only get the reservation in your country
            if (approved == null) {
                response.sendRedirect("warehouseErrorPage.jsp");
                return;
            }
            request.setAttribute("approved", approved);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/send.jsp");
            rd.forward(request, response);
        } else if ("delivery".equalsIgnoreCase(action)) {
            String[] fruitsId = request.getParameterValues("id");
            String[] loId = request.getParameterValues("loId");// from country 
            String[] date = request.getParameterValues("date");
            String[] qty = request.getParameterValues("qty");
            for (int i = 0; i < fruitsId.length; i++) {// check are only can the checked row data
                System.out.println(fruitsId[i]);
                System.out.println(loId[i]);//To location
                System.out.println(date[i]);
                System.out.println(qty[i]);
            }//locationId form
            if (!db.updateStatus(locationId, loId, fruitsId, qty, date)) {//update the reservation
                return;
            }
            response.sendRedirect("warehousePage.jsp");
        } else if ("listArrive".equalsIgnoreCase(action)) {
            ArrayList<reservation> reservation = db.getArrive(city, locationId);// only get the reservation in your country
            if (reservation == null) {
                response.sendRedirect("warehouseErrorPage2.jsp");
                return;
            }
            request.setAttribute("reservation", reservation);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/arrive.jsp");
            rd.forward(request, response);
        } else if ("end".equalsIgnoreCase(action)) {// do the update shop stock record
            String[] fruitsId = request.getParameterValues("id");
            String[] toId = request.getParameterValues("toId");// from country 
            String[] qty = request.getParameterValues("qty");
            String[] date = request.getParameterValues("date");
            for (int i = 0; i < fruitsId.length; i++) {// check are only can the checked row data
                System.out.println(fruitsId[i]);
                System.out.println(toId[i]);//To location
                System.out.println(qty[i]);
            }//locationId form
            if (!db.updateStock(toId, fruitsId, qty, date)) {//update the reservation
                return;
            }
            response.sendRedirect("warehousePage.jsp");
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
