/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package servlet;

import bean.user;
import db.UserDb;
import java.io.IOException;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;



@WebServlet(name = "handleLogin", urlPatterns = {"/login"})
public class handleLogin extends HttpServlet {

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

    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        doPost(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String action = request.getParameter("action");
        if (!isAuthenticated(request) && !("authenticate".equals(action))) {
            doLogin(request, response);
            return;
        }
        if ("authenticate".equals(action)) {
            doAuthenticate(request, response);
        } else if ("logout".equals(action)) {
            doLogout(request, response);
        } else {
            response.sendError(HttpServletResponse.SC_NOT_IMPLEMENTED);
        }
    }

    private void doAuthenticate(HttpServletRequest request, HttpServletResponse res) throws IOException, ServletException {
        String username = request.getParameter("username");
        String password = request.getParameter("password");

        String targetURL = null;
        //login success or not
        boolean isValid = db.isValidUser(username, password);
        if (isValid) {
            user userDetail = db.GetDetail(username, password);
            HttpSession session = request.getSession(true);
            //base on the role go to different page
            session.setAttribute("userInfo", userDetail);
            switch (userDetail.getRole()) {
                case "Bakery":
                    targetURL = "bakeryPage.jsp";
                    break;
                case "Warehouse":
                    targetURL = "warehousePage.jsp";
                    break;
                case "SeniorManagement":
                    targetURL = "managemePage.jsp";
                    break;
            }
        } else {
            targetURL = "loginError.jsp";
        }
        RequestDispatcher rd;
        rd = getServletContext().getRequestDispatcher("/" + targetURL);

        rd.forward(request, res);
    }

    private boolean isAuthenticated(HttpServletRequest req) {
        boolean rs = false;
        HttpSession session = req.getSession();

        if (session.getAttribute("userInfo") != null) {
            rs = true;
        }
        return rs;
    }

    private void doLogin(HttpServletRequest req, HttpServletResponse res) throws IOException, ServletException {
        String targetURL = "index.jsp";
        RequestDispatcher rd;
        rd = getServletContext().getRequestDispatcher("/" + targetURL);
        rd.forward(req, res);
    }

    private void doLogout(HttpServletRequest req, HttpServletResponse res) throws IOException, ServletException {
        HttpSession session = req.getSession(false);
        if (session != null) {
            session.removeAttribute("userInfo");
            session.invalidate();
        }
        doLogin(req, res);
    }

    @Override
    public String getServletInfo() {
        return "Short description";
    }
    
    
}
