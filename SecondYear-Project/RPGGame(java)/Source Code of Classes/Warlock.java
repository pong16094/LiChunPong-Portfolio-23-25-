import java.util.Vector;

public class Warlock extends Hero{
    private final String type = "Warlock";
    private int mp;
    
    public Warlock(String heroID, String heroName) {
        super(heroID, heroName);
        this.setHp(100);
        this.mp = 500;
        this.setDamage(200);
    }
    
    public int getMp() {
        return mp;
    }

    public void setMp(int mp) {
        this.mp = mp;
    }

    @Override
    public void callSkill() {
        if (mp > 0) mp -= 100;
        else mp = 0;
        setDamage(100);
    }

    @Override
    public String showHeroStatus() {
        return getHeroID() + 
                ", "+getHeroName() + ", Warlock, Hp: "+getHp() + 
                ", Damage: "+getDamage() + ", Mp: "+mp;
    }
    
    @Override
    public Vector getHeroStatus() {
        Vector status = new Vector();
        status.add(hp);
        status.add(damage);
        status.add(mp);
        return status;
    }

    @Override
    public String getType() {
        return type;
    }

    @Override
    public void updateHeroStatus(Vector status) {
        this.hp =(int)status.get(0);
        this.damage =(int)status.get(1);
        this.mp =(int)status.get(2);
    }
}
