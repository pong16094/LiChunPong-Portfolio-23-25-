// PlayerCreateFac.java

import java.util.Vector;

public class ShowPlayerFac implements CommandFactory {
		//public static  Scanner sc = new Scanner(System.in);

		private Vector<Player> _players;
	
        public ShowPlayerFac(){
            _players = null;
        }
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}


	public Command create() throws Exception {
		return new ShowPlayer(Main.currentPlayer);
	}
}
