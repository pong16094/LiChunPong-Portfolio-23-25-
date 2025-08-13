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

@WebServlet(name = "bakeryUpdate", urlPatterns = {"/bakeryUpdate"})
public class bakeryUpdate extends HttpServlet {

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
        int locationId = info.getShopId();
        System.out.println(locationId);
        if ("list".equalsIgnoreCase(action)) {
            ArrayList<fruit> stocks = db.getStocks(locationId);
            request.setAttribute("stocks", stocks);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/updateFruit.jsp");
            rd.forward(request, response);
        } else if ("update".equalsIgnoreCase(action)) {
            String[] fruitsId = request.getParameterValues("id");
            String[] qty = request.getParameterValues("qty");
            db.updateFruits(locationId, fruitsId, qty);
            response.sendRedirect("bakeryPage.jsp");
        } else if ("borrow".equalsIgnoreCase(action)) {
            int getid = 0;
            String shopId = request.getParameter("shopId");
            ArrayList<location> smCtShop = db.getSameCity(locationId);//get same city shop
            System.out.print("*************In the Servlet**********" + smCtShop);
            if (shopId == null) {
                getid = smCtShop.get(0).getLocationId();//it will be use in getting the record
            } else {
                getid = Integer.parseInt(shopId);
            }
            ArrayList<fruit> shop = db.getStocks(locationId);//current shop
            ArrayList<fruit> other = db.getStocks(getid);//same city shop
            request.setAttribute("shop", shop);
            request.setAttribute("other", other);
            request.setAttribute("otherShopId", getid);
            request.setAttribute("allSC", smCtShop);// help me show all same city
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/borrow.jsp");
            rd.forward(request, response);
        } else if ("doBorrow".equalsIgnoreCase(action)) {
            int getid = 0;
            int shopId = Integer.parseInt(request.getParameter("borrowShopId"));//the borrow shop Id

            String[] fruitsId = request.getParameterValues("id");
            String[] qty = request.getParameterValues("qty");
            db.doBorrow(locationId,shopId, fruitsId, qty);
            response.sendRedirect("bakeryUpdate?action=list");
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
