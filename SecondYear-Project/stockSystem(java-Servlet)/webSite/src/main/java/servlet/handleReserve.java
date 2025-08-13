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

@WebServlet(name = "handleReserve", urlPatterns = {"/handleReserve"})
public class handleReserve extends HttpServlet {

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
            ArrayList<fruit> fruits = db.getFruits();
            request.setAttribute("fruits", fruits);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/reserveForm.jsp");
            rd.forward(request, response);
        } else if ("order".equalsIgnoreCase(action)) {
            HttpSession session = request.getSession();
            user info = (user) session.getAttribute("userInfo");
            int locationId = info.getShopId();
            String[] fruitsId = request.getParameterValues("fruitId");
            String[] qty = request.getParameterValues("quantity");
            for (int i = 0; i < fruitsId.length; i++) {
                if (!"0".equalsIgnoreCase(qty[i])) {
                    System.out.println(locationId + "Id:" + fruitsId[i] + "qty:" + qty[i]);
                    if (!db.addReservation(locationId, Integer.parseInt(fruitsId[i]), Integer.parseInt(qty[i]))) {
                        return;
                    }
                }
            }
            response.sendRedirect("handleReserve?action=record");
        } else if ("record".equalsIgnoreCase(action)) {
            HttpSession session = request.getSession();
            user info = (user) session.getAttribute("userInfo");
            int locationId = info.getShopId();
            ArrayList<reservation> records = db.getRecords(locationId);
            request.setAttribute("records", records);
            RequestDispatcher rd;
            rd = getServletContext().getRequestDispatcher("/checkRecord.jsp");
            rd.forward(request, response);
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
