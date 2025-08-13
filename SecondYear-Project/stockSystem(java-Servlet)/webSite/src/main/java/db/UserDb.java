/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package db;

import bean.fruit;
import bean.location;
import bean.reservation;
import bean.user;
import java.io.IOException;
import java.sql.*;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;

/**
 *
 * @author User
 */
public class UserDb {

    private String url = "";
    private String username = "";
    private String password = "";

    public UserDb() {
    }

    public UserDb(String url, String username, String password) {
        this.url = url;
        this.username = username;
        this.password = password;
    }

    public ArrayList<reservation> getBySeason(String type) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<reservation> reservations = null;
        ResultSet rs = null;
        try {

            cnnct = getConnection();
            String sql = "";

            switch (type) {
                case "shop":
                    sql = "SELECT l.locationId AS id, l.locationName AS name, f.fruitId AS fruitId, f.fruitName AS fruitName, CASE WHEN MONTH(r.date) BETWEEN 3 AND 5 THEN 'Spring' WHEN MONTH(r.date) BETWEEN 6 AND 8 THEN 'Summer' WHEN MONTH(r.date) BETWEEN 9 AND 11 THEN 'Autumn' ELSE 'Winter' END AS seasonName, SUM(r.quantity) AS totalQuantityNeeded FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN fruit f ON r.fruitId = f.fruitId WHERE l.locationType = 'Shop' GROUP BY l.locationId, l.locationName, f.fruitId, f.fruitName, seasonName ORDER BY l.locationId ASC, totalQuantityNeeded DESC, seasonName";
                    break;
                case "city":
                    sql = "SELECT c.cityId AS id, c.city AS name, f.fruitId AS fruitId, f.fruitName AS fruitName, CASE WHEN MONTH(r.date) BETWEEN 3 AND 5 THEN 'Spring' WHEN MONTH(r.date) BETWEEN 6 AND 8 THEN 'Summer' WHEN MONTH(r.date) BETWEEN 9 AND 11 THEN 'Autumn' ELSE 'Winter' END AS seasonName, SUM(r.quantity) AS totalQuantityNeeded FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN city c ON l.cityId = c.cityId JOIN fruit f ON r.fruitId = f.fruitId GROUP BY c.cityId, c.city, f.fruitId, f.fruitName, seasonName ORDER BY c.cityId ASC, totalQuantityNeeded DESC, seasonName";
                    break;
                case "country":
                    sql = "SELECT c.cityId AS id, c.country AS name, f.fruitId AS fruitId, f.fruitName AS fruitName, CASE WHEN MONTH(r.date) BETWEEN 3 AND 5 THEN 'Spring' WHEN MONTH(r.date) BETWEEN 6 AND 8 THEN 'Summer' WHEN MONTH(r.date) BETWEEN 9 AND 11 THEN 'Autumn' ELSE 'Winter' END AS seasonName, SUM(r.quantity) AS totalQuantityNeeded FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN city c ON l.cityId = c.cityId JOIN fruit f ON r.fruitId = f.fruitId GROUP BY c.country, f.fruitId, f.fruitName, seasonName ORDER BY c.country, totalQuantityNeeded DESC, seasonName";
                    break;
            }
            pStmnt = cnnct.prepareStatement(sql);
            rs = pStmnt.executeQuery();
            reservations = new ArrayList<reservation>();
            while (rs.next()) {

                reservation reservation = new reservation();
                reservation.setLocationId(rs.getInt("id"));
                reservation.setCountry(rs.getString("name"));
                reservation.setFruitId(rs.getInt("fruitId"));
                reservation.setName(rs.getString("fruitName"));
                reservation.setSeason(rs.getString("seasonName"));
                reservation.setQty(rs.getInt("totalQuantityNeeded"));
                reservations.add(reservation);


                reservations.add(reservation);
                System.out.println(reservation);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return reservations;
    }

    public ArrayList<reservation> getByType(String type) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<reservation> reservations = null;
        ResultSet rs = null;
        try {

            cnnct = getConnection();
            String sql = "";

            switch (type) {
                case "shop":
                    sql = "SELECT l.locationId AS id, l.locationName AS name, f.fruitId AS fruitId, f.fruitName AS fruitName, SUM(r.quantity) AS totalQuantityNeeded FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN fruit f ON r.fruitId = f.fruitId WHERE l.locationType = 'Shop' GROUP BY l.locationId, l.locationName, f.fruitId, f.fruitName ORDER BY l.locationId ASC, totalQuantityNeeded DESC";
                    break;
                case "city":
                    sql = "SELECT c.cityId AS id, c.city AS name, f.fruitId AS fruitId, f.fruitName AS fruitName, SUM(r.quantity) AS totalQuantityNeeded FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN city c ON l.cityId = c.cityId JOIN fruit f ON r.fruitId = f.fruitId GROUP BY c.cityId, c.city, f.fruitId, f.fruitName ORDER BY c.cityId ASC, totalQuantityNeeded DESC";
                    break;
                case "country":
                    sql = "SELECT c.cityId AS id, c.country AS name, f.fruitId AS fruitId, f.fruitName AS fruitName, SUM(r.quantity) AS totalQuantityNeeded FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN city c ON l.cityId = c.cityId JOIN fruit f ON r.fruitId = f.fruitId GROUP BY c.country, f.fruitId, f.fruitName ORDER BY c.country, totalQuantityNeeded DESC";
                    break;
            }
            pStmnt = cnnct.prepareStatement(sql);
            rs = pStmnt.executeQuery();
            reservations = new ArrayList<reservation>();
            while (rs.next()) {
                reservation reservation = new reservation();
                reservation.setFruitId(rs.getInt("fruitId"));
                reservation.setLocationId(rs.getInt("id"));
                reservation.setCountry(rs.getString("name"));
                reservation.setQty(rs.getInt("totalQuantityNeeded"));
                reservation.setName(rs.getString("fruitName"));

                reservations.add(reservation);
                System.out.println(reservation);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return reservations;
    }

    public boolean addFruit(String name, String country) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String preQueryStatement = "INSERT INTO fruit(fruitName, source_country) VALUES (?,?)";
            pStmnt = cnnct.prepareStatement(preQueryStatement);
            pStmnt.setString(1, name);
            pStmnt.setString(2, country);
            int RowCount = pStmnt.executeUpdate();
            if (RowCount >= 1) {
                isSuccess = true;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public fruit getFruitById(String fruitId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        fruit fruit = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT * FROM fruit WHERE fruitId=?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, fruitId);
            rs = pStmnt.executeQuery();
            if (rs.next()) {
                fruit = new fruit();
                fruit.setFruitId(rs.getInt("fruitId"));
                fruit.setName(rs.getString("fruitName"));
                fruit.setCity(rs.getString("source_country"));

                System.out.println(fruit);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return fruit;
    }

    public boolean editFruit(fruit fruit) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String sql = "UPDATE fruit SET fruitId=?,fruitName=?,source_country=? WHERE fruitId=?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, fruit.getFruitId());
            pStmnt.setString(2, fruit.getName());
            pStmnt.setString(3, fruit.getCity());
            pStmnt.setInt(4, fruit.getFruitId());
            isSuccess = pStmnt.execute();

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean editRecord(user user) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String sql = "UPDATE user SET userId=?,username=?,password=?,fullName=?,role=?,city=?,shopId=? WHERE userId=?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, user.getUserId());
            pStmnt.setString(2, user.getUserName());
            pStmnt.setString(3, user.getPassword());
            pStmnt.setString(4, user.getFullName());
            pStmnt.setString(5, user.getRole());
            pStmnt.setInt(6, user.getCityId());
            pStmnt.setInt(7, user.getShopId());
            pStmnt.setInt(8, user.getUserId());
            isSuccess = pStmnt.execute();

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean delFruit(String fruitId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String sql = "DELETE FROM fruit where fruitId = ?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, fruitId);
            isSuccess = pStmnt.execute();

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean delRecord(String userId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String sql = "DELETE FROM user where userId = ?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, userId);
            isSuccess = pStmnt.execute();

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public user getUserById(String userId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        user user = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT * FROM user WHERE userId=?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, userId);
            rs = pStmnt.executeQuery();
            if (rs.next()) {
                user = new user();
                user.setUserId(rs.getInt("userId"));
                user.setUserName(rs.getString("username"));
                user.setPassword(rs.getString("password"));
                user.setFullName(rs.getString("fullName"));
                user.setRole(rs.getString("role"));
                user.setCityId(rs.getInt("city"));
                user.setShopId(rs.getInt("shopId"));

                System.out.println(user);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return user;
    }

    public ArrayList<user> getUser() {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<user> users = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT * FROM user";
            pStmnt = cnnct.prepareStatement(sql);
            rs = pStmnt.executeQuery();
            users = new ArrayList<user>();
            while (rs.next()) {
                user user = new user();
                user.setUserId(rs.getInt("userId"));
                user.setUserName(rs.getString("username"));
                user.setPassword(rs.getString("password"));
                user.setFullName(rs.getString("fullName"));
                user.setRole(rs.getString("role"));
                user.setCityId(rs.getInt("city"));
                user.setShopId(rs.getInt("shopId"));

                users.add(user);
                System.out.println(user);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return users;
    }

    public ArrayList<reservation> getArrive(int city, int locationId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<reservation> reservations = null;
        ResultSet rs = null;
        try {
            if (!getWarehouseType(locationId)) {//only CentralWarehouse can check their reservation
                return reservations;
            }
            cnnct = getConnection();
            String sql = "SELECT r.*,f.fruitName,f.source_country FROM reservation r JOIN location l ON r.locationId = l.locationId JOIN city c ON l.cityId = c.cityId JOIN fruit f ON f.fruitId = r.fruitId WHERE c.country = (SELECT country FROM city WHERE cityId = ? ) AND status='Delivering'";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, city);
            rs = pStmnt.executeQuery();
            reservations = new ArrayList<reservation>();
            while (rs.next()) {
                reservation reservation = new reservation();
                reservation.setFruitId(rs.getInt("fruitId"));
                reservation.setLocationId(rs.getInt("locationId"));
                reservation.setCountry(rs.getString("source_country"));
                reservation.setQty(rs.getInt("quantity"));
                reservation.setName(rs.getString("fruitName"));

                Timestamp timestamp = rs.getTimestamp("updateAt");
                LocalDateTime ldt = timestamp.toLocalDateTime();
                String formattedDate = ldt.format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
                reservation.setDate(formattedDate);

                reservations.add(reservation);
                System.out.println(reservation);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return reservations;
    }

    public boolean updateStock(String[] toId, String[] fruitId, String[] qty, String[] date) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        /*
        Timestamp ts = Timestamp.valueOf(formattedDate);
        stmt.setTimestamp(1, ts);
         */
        try {
            cnnct = getConnection();
            for (int i = 0; i < fruitId.length; i++) {// get the quantity in stock
                Timestamp ts = Timestamp.valueOf(date[i]);
                String preQueryStatement = "UPDATE reservation SET status ='Delivered' WHERE locationId=? AND fruitId=? AND updateAt=? AND quantity=?";
                pStmnt = cnnct.prepareStatement(preQueryStatement);
                pStmnt.setInt(1, Integer.parseInt(toId[i]));
                pStmnt.setInt(2, Integer.parseInt(fruitId[i]));
                pStmnt.setTimestamp(3, ts);
                pStmnt.setInt(4, Integer.parseInt(qty[i]));
                int RowCount = pStmnt.executeUpdate();
                if (RowCount == 0) {
                    System.out.println("No record updated ");
                }

                preQueryStatement = "UPDATE stock SET quantity=quantity+? WHERE locationId=? AND fruitId=?"; // update the stock record of the source warehouse
                pStmnt = cnnct.prepareStatement(preQueryStatement);
                pStmnt.setInt(1, Integer.parseInt(qty[i]));
                pStmnt.setInt(2, Integer.parseInt(toId[i]));
                pStmnt.setString(3, fruitId[i]);
                RowCount = pStmnt.executeUpdate();
                if (RowCount == 0) {
                    System.out.println("No record updated for fruitId: " + fruitId[i]);
                }
            }
            isSuccess = true;

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean updateStatus(int fromId, String[] toId, String[] fruitId, String[] qty, String[] date) {
//get stock number -> check enought stock  ->update reservation status -> reduce stock -> write to log
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        ResultSet rs = null;

        try {
            cnnct = getConnection();
            int fis = 0;

            for (int i = 0; i < fruitId.length; i++) {// get the quantity in stock
                String checkStock = "SELECT * FROM stock where fruitId=? and locationId=?";
                pStmnt = cnnct.prepareStatement(checkStock);
                pStmnt.setInt(1, Integer.parseInt(fruitId[i]));
                pStmnt.setInt(2, fromId);
                rs = pStmnt.executeQuery();
                if (rs.next()) {
                    fis = rs.getInt("quantity");
                }

                if (fis >= Integer.parseInt(qty[i])) {// check the stock has enought qty?

                    String preQueryStatement = "UPDATE reservation SET status ='Delivering' WHERE locationId=? AND fruitId=? AND date=? AND quantity=?";
                    pStmnt = cnnct.prepareStatement(preQueryStatement);
                    pStmnt.setInt(1, Integer.parseInt(toId[i]));
                    pStmnt.setInt(2, Integer.parseInt(fruitId[i]));
                    pStmnt.setString(3, date[i]);
                    pStmnt.setInt(4, Integer.parseInt(qty[i]));
                    int RowCount = pStmnt.executeUpdate();
                    if (RowCount == 0) {
                        System.out.println("No record updated for fruitId: " + fruitId[i]);
                    }

                    preQueryStatement = "UPDATE stock SET quantity=quantity-? WHERE locationId=? AND fruitId=?"; // update the stock record of the source warehouse
                    pStmnt = cnnct.prepareStatement(preQueryStatement);
                    pStmnt.setInt(1, Integer.parseInt(qty[i]));
                    pStmnt.setInt(2, fromId);
                    pStmnt.setString(3, fruitId[i]);
                    RowCount = pStmnt.executeUpdate();
                    if (RowCount == 0) {
                        System.out.println("No record updated for fruitId: " + fruitId[i]);
                    }

                    // Parse the string to LocalDate
                    LocalDate convertDate = LocalDate.parse(date[i]);
                    // Format the date to desired pattern
                    DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyyMMdd");
                    String formattedDate = convertDate.format(formatter);
                    String num = fromId + formattedDate + toId[i];

                    System.out.println(num);//for debug
                    preQueryStatement = "INSERT INTO delivery_log(number, source, destination, fruitId, quantity, date) VALUES (?,?,?,?,?,?)";//add to log
                    pStmnt = cnnct.prepareStatement(preQueryStatement);
                    pStmnt.setString(1, num);
                    pStmnt.setInt(2, fromId);
                    pStmnt.setInt(3, Integer.parseInt(toId[i]));
                    pStmnt.setInt(4, Integer.parseInt(fruitId[i]));
                    pStmnt.setInt(5, Integer.parseInt(qty[i]));
                    pStmnt.setObject(6, LocalDate.now());
                    int RowCount2 = pStmnt.executeUpdate();
                    if (RowCount2 == 0) {
                        System.out.println("insert fail : " + fruitId[i]);
                    }
                } else {
                    System.out.println("Stock has number" + fis + " of" + fruitId[i] + "It need " + qty[i]);
                }
            }
            isSuccess = true;

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean cfReservation(String[] fruitId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {

            cnnct = getConnection();
            for (int i = 0; i < fruitId.length; i++) {
                String preQueryStatement = "UPDATE reservation SET status = 'Approved' WHERE date >= CURDATE() - INTERVAL 14 DAY AND status = 'Pending' and fruitId = ?;";
                pStmnt = cnnct.prepareStatement(preQueryStatement);
                pStmnt.setInt(1, Integer.parseInt(fruitId[i]));
                System.out.println(fruitId[i]);
                int RowCount = pStmnt.executeUpdate();
            }
            isSuccess = true;

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public ArrayList<reservation> getApproved(int city, int locationId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<reservation> reservations = null;
        ResultSet rs = null;
        String country = getCountry(city);
        System.out.println(city);
        System.out.println(country);
        try {
            if (getWarehouseType(locationId)) {//only source lWarehouse can check their reservation
                return reservations;
            }
            cnnct = getConnection();
            String sql = "SELECT r.quantity,f.fruitId,r.locationId, f.fruitName, r.date, c.country FROM reservation r JOIN fruit f ON r.fruitId = f.fruitId JOIN location l ON r.locationId = l.locationId JOIN city c ON l.cityId = c.cityId WHERE r.status = 'Approved' and f.source_country=? ORDER BY r.date";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, country);
            rs = pStmnt.executeQuery();
            reservations = new ArrayList<reservation>();
            while (rs.next()) {
                reservation reservation = new reservation();
                reservation.setFruitId(rs.getInt("fruitId"));
                reservation.setLocationId(rs.getInt("locationId"));
                //Object convert to String
                LocalDate reserveDate = rs.getObject("date", LocalDate.class);
                String stringDate = reserveDate.toString(); // Already in yyyy-MM-dd
                reservation.setDate(stringDate);

                reservation.setCountry(rs.getString("country"));
                reservation.setQty(rs.getInt("quantity"));
                reservation.setName(rs.getString("fruitName"));
                reservations.add(reservation);
                System.out.println(reservation);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return reservations;
    }

    public ArrayList<reservation> getReservation(int city, int locationId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<reservation> reservations = null;
        ResultSet rs = null;
        String country = getCountry(city);
        try {
            if (getWarehouseType(locationId)) {//only Source Warehouse can check their reservation
                return null;
            }
            cnnct = getConnection();
            String sql = "SELECT f.source_country,f.fruitName, r.fruitId, SUM(r.quantity) AS total_quantity FROM reservation r INNER JOIN fruit f ON r.fruitId = f.fruitId WHERE r.date >= CURDATE() - INTERVAL 14 DAY AND r.status = 'Pending' and f.source_country=? GROUP BY f.source_country, r.fruitId ORDER BY f.source_country, r.fruitId";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, country);
            rs = pStmnt.executeQuery();
            reservations = new ArrayList<reservation>();
            while (rs.next()) {
                reservation reservation = new reservation();
                reservation.setFruitId(rs.getInt("fruitId"));
                reservation.setCountry(rs.getString("source_country"));
                reservation.setQty(rs.getInt("total_quantity"));
                reservation.setName(rs.getString("fruitName"));
                reservations.add(reservation);
                System.out.println(reservation);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return reservations;
    }

    public String getCountry(int city) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT country FROM city WHERE cityId = ?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, city);

            rs = pStmnt.executeQuery();
            if (rs.next()) {
                return rs.getString("country");
            } else {
                System.out.println("can not find");
            }

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return null;
    }

    public boolean getWarehouseType(int locationId) {//if return true = locationId central warehouse
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ResultSet rs = null;
        boolean isSuccess = false;

        try {
            cnnct = getConnection();
            String sql = "SELECT locationType FROM location WHERE locationId=? and locationType='CentralWarehouse'";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, locationId);

            rs = pStmnt.executeQuery();
            if (rs.next()) {
                isSuccess = true;// equal to CentralWarehouse
            } else {
                isSuccess = false;
            }

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public ArrayList<location> getSameCity(int locationId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<location> locations = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            locations = new ArrayList<location>();
            String sql = "SELECT * FROM location WHERE cityId = ( SELECT cityId FROM location WHERE locationId = ? ) AND locationId != ? and locationType='Shop'";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, locationId);
            pStmnt.setInt(2, locationId);
            rs = pStmnt.executeQuery();
            while (rs.next()) {
                location location = new location();
                location.setLocationId(rs.getInt("locationId"));
                location.setLocationName(rs.getString("locationName"));
                locations.add(location);
                System.out.println(location);
            }

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return locations;
    }

    public Connection getConnection() throws SQLException, IOException {
        try {
            Class.forName("com.mysql.jdbc.Driver");
        } catch (ClassNotFoundException ex) {
            ex.printStackTrace();
        }
        return DriverManager.getConnection(url, username, password);

    }

    public boolean doBorrow(int locationId, int shopId, String[] fruitId, String[] qty) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            for (int i = 0; i < fruitId.length; i++) {
                String preQueryStatement = "UPDATE stock SET quantity = quantity - ? WHERE fruitId = ? AND locationId = ?";//do decrease 
                pStmnt = cnnct.prepareStatement(preQueryStatement);
                pStmnt.setInt(1, Integer.parseInt(qty[i]));
                pStmnt.setInt(2, Integer.parseInt(fruitId[i]));
                pStmnt.setInt(3, shopId);
                int RowCount = pStmnt.executeUpdate();

                preQueryStatement = "UPDATE stock SET quantity = quantity + ? WHERE fruitId = ? AND locationId = ?";
                pStmnt = cnnct.prepareStatement(preQueryStatement);
                pStmnt.setInt(1, Integer.parseInt(qty[i]));
                pStmnt.setInt(2, Integer.parseInt(fruitId[i]));
                pStmnt.setInt(3, locationId);
                RowCount = pStmnt.executeUpdate();

            }
            isSuccess = true;

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean updateFruits(int locationId, String[] fruitId, String[] qty) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            for (int i = 0; i < fruitId.length; i++) {
                String preQueryStatement = "UPDATE stock SET quantity=? WHERE fruitId=? and locationId=?";
                pStmnt = cnnct.prepareStatement(preQueryStatement);
                pStmnt.setInt(1, Integer.parseInt(qty[i]));
                pStmnt.setInt(2, Integer.parseInt(fruitId[i]));
                pStmnt.setInt(3, locationId);
                int RowCount = pStmnt.executeUpdate();
                if (RowCount == 0) {
                    System.out.println("No record updated for fruitId: " + fruitId[i]);
                }
            }
            isSuccess = true;

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public ArrayList<fruit> getStocks(int locationId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<fruit> stocks = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT s.fruitId, s.quantity,f.fruitName FROM stock s INNER JOIN fruit f on f.fruitId = s.fruitId where locationId=?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, locationId);
            rs = pStmnt.executeQuery();
            stocks = new ArrayList<fruit>();
            while (rs.next()) {
                fruit stock = new fruit();
                stock.setFruitId(rs.getInt("fruitId"));

                stock.setQty(rs.getInt("quantity"));
                stock.setName(rs.getString("fruitName"));
                stocks.add(stock);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return stocks;
    }

    public ArrayList<reservation> getRecords(int locationId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<reservation> records = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT r.fruitId, r.date, r.quantity, r.status,f.fruitName FROM reservation r INNER JOIN fruit f on f.fruitId = r.fruitId where locationId=? order by r.date DESC";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, locationId);
            rs = pStmnt.executeQuery();
            records = new ArrayList<reservation>();
            while (rs.next()) {
                reservation record = new reservation();
                record.setFruitId(rs.getInt("fruitId"));
                //Object convert to String
                LocalDate reserveDate = rs.getObject("date", LocalDate.class);
                String stringDate = reserveDate.toString(); // Already in yyyy-MM-dd
                record.setDate(stringDate);

                record.setQty(rs.getInt("quantity"));
                record.setStatus(rs.getString("status"));
                record.setName(rs.getString("fruitName"));
                records.add(record);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return records;
    }

    public ArrayList<fruit> getFruits() {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<fruit> fruits = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT * FROM fruit";
            pStmnt = cnnct.prepareStatement(sql);
            rs = pStmnt.executeQuery();
            fruits = new ArrayList<fruit>();
            while (rs.next()) {
                fruit fruit = new fruit();
                fruit.setFruitId(rs.getInt("fruitId"));
                fruit.setName(rs.getString("fruitName"));
                fruit.setCity(rs.getString("source_country"));
                fruits.add(fruit);
            }

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return fruits;
    }

    public boolean addReservation(int locationId, int fruitId, int qty) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String preQueryStatement = "INSERT INTO reservation(locationId, fruitId, date, quantity, status) VALUES(?,?,?,?,?)";
            pStmnt = cnnct.prepareStatement(preQueryStatement);
            pStmnt.setInt(1, locationId);
            pStmnt.setInt(2, fruitId);
            pStmnt.setObject(3, LocalDate.now());
            pStmnt.setInt(4, qty);
            pStmnt.setString(5, "Pending");
            int RowCount = pStmnt.executeUpdate();
            if (RowCount >= 1) {
                isSuccess = true;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public boolean addUser(String username, String password, String fullname, String role, int city, int shopId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isSuccess = false;
        try {
            cnnct = getConnection();
            String preQueryStatement = "INSERT INTO user(username, password, fullName, role, city, shopId) VALUES(?,?,?,?,?,?)";
            pStmnt = cnnct.prepareStatement(preQueryStatement);
            pStmnt.setString(1, username);
            pStmnt.setString(2, password);
            pStmnt.setString(3, fullname);
            pStmnt.setString(4, role);
            pStmnt.setInt(5, city);
            pStmnt.setInt(6, shopId);
            int RowCount = pStmnt.executeUpdate();
            if (RowCount >= 1) {
                isSuccess = true;
            }
        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isSuccess;
    }

    public location getShop(int cityId) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        location shop = new location();
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT * FROM location WHERE cityId=?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setInt(1, cityId);
            rs = pStmnt.executeQuery();
            if (rs.next()) {
                shop.setLocationId(rs.getInt("locationId"));
                shop.setLocationName(rs.getString("locationName"));
                shop.setCityId(rs.getInt(rs.getString("locationName")));
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return shop;
    }

    public ArrayList<location> getShops() {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        ArrayList<location> shops = null;
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT l.locationId, l.cityId, l.locationName, l.locationType,c.city\n"
                    + "FROM location l\n"
                    + "JOIN city c ON l.cityId = c.cityId;";
            pStmnt = cnnct.prepareStatement(sql);
            rs = pStmnt.executeQuery();
            shops = new ArrayList<location>();
            while (rs.next()) {
                location shop = new location();
                shop.setLocationId(rs.getInt("locationId"));
                shop.setCityId(rs.getInt("cityId"));
                shop.setLocationName(rs.getString("locationName"));
                shop.setLocationType(rs.getString("locationType"));
                shop.setCity(rs.getString("city"));
                shops.add(shop);
            }

            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return shops;
    }

    public user GetDetail(String username, String password) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        user user = new user();
        ResultSet rs = null;
        try {
            cnnct = getConnection();
            String sql = "SELECT userId, role, city,shopId FROM user WHERE username = ? and password =?";
            pStmnt = cnnct.prepareStatement(sql);
            pStmnt.setString(1, username);
            pStmnt.setString(2, password);
            rs = pStmnt.executeQuery();
            if (rs.next()) {
                user.setUserId(rs.getInt(1));
                user.setRole(rs.getString(2));
                user.setCityId(rs.getInt(3));
                user.setShopId(rs.getInt(4));
                System.out.print(user);
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return user;
    }

    public boolean isValidUser(String username, String password) {
        Connection cnnct = null;
        PreparedStatement pStmnt = null;
        boolean isValid = false;

        try {
            cnnct = getConnection();
            String preQueryStatement = "SELECT * FROM user WHERE username = ? and password =?";

            pStmnt = cnnct.prepareStatement(preQueryStatement);
            pStmnt.setString(1, username);
            pStmnt.setString(2, password);
            ResultSet rs = pStmnt.executeQuery();
            if (rs.next()) {
                isValid = true;
            }
            pStmnt.close();
            cnnct.close();

        } catch (SQLException ex) {
            ex.printStackTrace();
        } catch (IOException ex) {
            ex.printStackTrace();
        }
        return isValid;
    }
}
