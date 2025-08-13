// PlayerCreateFac.java

import java.util.Vector;

public class AllPlayerFac implements CommandFactory {
		//public static  Scanner sc = new Scanner(System.in);

		private Vector<Player> _players;
	
        public AllPlayerFac(){
            _players = null;
        }
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}


	public Command create() throws Exception {
		return new AllPlayer(_players);
	}
}
