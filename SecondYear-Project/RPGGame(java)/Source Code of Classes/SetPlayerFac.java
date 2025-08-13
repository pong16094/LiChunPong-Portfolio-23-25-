// PlayerCreateFac.java

import java.util.Vector;

public class SetPlayerFac implements CommandFactory {
		//public static  Scanner sc = new Scanner(System.in);

		private Vector<Player> _players;
	
        public SetPlayerFac(){
            _players = null;
        }
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}


	public Command create() throws Exception {
        System.out.print("Please input player ID:- ");
		String playerID = Main.sc.nextLine();

		return new SetPlayer(_players,playerID);
	}
}
