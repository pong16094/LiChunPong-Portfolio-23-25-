import java.util.Vector;

public abstract class Hero {
    protected String heroID;
    protected String heroName;
    protected int hp;
    protected int damage;

    public Hero(String heroID, String heroName) {
        this.heroID = heroID;
        this.heroName = heroName;
        this.hp = 200;
    }

    public String getHeroID() {
        return heroID;
    }

    public String getHeroName() {
        return heroName;
    }

    public void setHeroName(String heroName) {
        this.heroName = heroName;
    }

    public int getHp() {
        return hp;
    }

    public void setHp(int hp) {
        this.hp = hp;
    }

    public int getDamage() {
        return damage;
    }

    public void setDamage(int damage) {
        this.damage = damage;
    }
    
    public abstract void callSkill();
    
    public abstract String showHeroStatus();
    
    public abstract Vector getHeroStatus();

    public abstract String getType();
    
    public abstract void updateHeroStatus(Vector status);
}
