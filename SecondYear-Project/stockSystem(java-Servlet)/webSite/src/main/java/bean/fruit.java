/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package bean;


public class fruit {
    private int fruitId,qty;
    private String name,city;

    public fruit() {
    }

    public fruit(int fruitId, String name, String city) {
        this.fruitId = fruitId;
        this.name = name;
        this.city = city;
    }

    public int getQty() {
        return qty;
    }

    public void setQty(int qty) {
        this.qty = qty;
    }

    public int getFruitId() {
        return fruitId;
    }

    public void setFruitId(int fruitId) {
        this.fruitId = fruitId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    @Override
    public String toString() {
        return "fruit{" + "fruitId=" + fruitId + ", qty=" + qty + ", name=" + name + ", city=" + city + '}';
    }
    
}
