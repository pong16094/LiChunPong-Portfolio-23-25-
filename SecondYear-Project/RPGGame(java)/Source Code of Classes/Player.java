import java.util.Vector;

public class Player {
    private String playerID;
    private String playerName;
    private Vector<Hero> heroes;

    public Player(String playerID, String playerName){
        this.playerID = playerID;
        this.playerName = playerName;
        heroes = new Vector<>();
        System.out.println("Player "+ this.playerName +" is created. ");

    }
    public String getPlayerID() {
        return playerID;
    }

    public String getPlayerName() {
        return playerName;
    }

    public void setPlayerName(String playerName) {
        this.playerName = playerName;
    }

    public Vector<Hero> getHeroes() {
        return heroes;
    }

    public void addHero(Hero hero) {
        //add your own codes
        this.heroes.add(hero);
    }
    
    public void removeHero(Hero hero) {
        //add your own codes
        this.heroes.remove(hero);
    }
    
    public void showPlayerDetails(){
        //add your own codes
        System.out.println("Player "+ playerName + " (" + playerID + ") \n" + "Heroes:");
        if(heroes.isEmpty()){
            System.out.println("No heroes available.");
        }
        for(int i = 0; i<heroes.size();i++){
            System.out.println(heroes.elementAt(i).showHeroStatus());

        }
    }
}
