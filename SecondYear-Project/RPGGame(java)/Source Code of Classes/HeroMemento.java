import java.util.Vector;

public class HeroMemento implements Memento {
    private Hero mhero;
    private Player mplayer;
    private Vector mstatus;

    public HeroMemento(Player xplayer, int xheroIndex) {
        mplayer = xplayer;
        mhero = xplayer.getHeroes().get(xheroIndex);
        mstatus = mhero.getHeroStatus();

    } 
    //ne
    public void restore() {
      mhero.updateHeroStatus(mstatus);
      System.out.print("");
    } 
    
}