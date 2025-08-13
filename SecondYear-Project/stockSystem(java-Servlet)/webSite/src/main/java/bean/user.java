/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bean;

/**
 *
 * @author User
 */
public class user {
    private int userId,shopId,cityId;
    private String role, userName,password,fullName;

    public user() {
    }

    public user(int userId, int shopId, int cityId, String role, String userName, String password, String fullName) {
        this.userId = userId;
        this.shopId = shopId;
        this.cityId = cityId;
        this.role = role;
        this.userName = userName;
        this.password = password;
        this.fullName = fullName;
    }

    
    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public int getShopId() {
        return shopId;
    }

    public void setShopId(int shopId) {
        this.shopId = shopId;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }

    public int getCityId() {
        return cityId;
    }

    public void setCityId(int cityId) {
        this.cityId = cityId;
    }


    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getFullName() {
        return fullName;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    @Override
    public String toString() {
        return "user{" + "userId=" + userId + ", shopId=" + shopId + ", cityId=" + cityId + ", role=" + role + ", userName=" + userName + ", password=" + password + ", fullName=" + fullName + '}';
    }

  
    
    
}
