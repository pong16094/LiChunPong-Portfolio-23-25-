public class PlayerIDMemento implements Memento {
    private Player mplayer;
    private String mplayerName;

	
    public PlayerIDMemento(Player xplayer) {
      mplayer = xplayer;
      mplayerName = xplayer.getPlayerName();
    } 
    
    public void restore() {
      mplayer.setPlayerName(mplayerName);
    } 
    
}