import java.util.Vector;

public class Warrior extends Hero{
    private final String type = "Warrior";
    private int defencePoint;

    public Warrior(String heroID, String heroName) {
        super(heroID, heroName);
        this.defencePoint = 500;
        this.setHp(500);
        this.setDamage(0);
    }

    public int getDefencePoint() {
        return defencePoint;
    }

    public void setDefencePoint(int defencePoint) {
        this.defencePoint = defencePoint;
    }

    @Override
    public void callSkill() {
        if (defencePoint<0) defencePoint = 0;
        this.setDamage(defencePoint/2);
        defencePoint -= 100;
    };



@Override
    public Vector getHeroStatus() {
        Vector status = new Vector();
        status.add(hp);
        status.add(damage);
        status.add(defencePoint);
        return status;
    }

    @Override
    public String showHeroStatus() {
       return getHeroID() + 
                ", "+getHeroName() + ", Hp: "+getHp() + 
                ", Damage: "+getDamage() + ", Defence Point: "+defencePoint;

    }

    @Override
    public String getType() {
        return type;
    }

    @Override
    public void updateHeroStatus(Vector status) {
        this.hp =(int)status.get(0);
        this.damage =(int)status.get(1);
        this.defencePoint =(int)status.get(2);
    }
}

