// PlayerCreateFac.java

import java.util.Vector;

public class SetNameFac implements CommandFactory {

		private Vector<Player> _players;
	
        public SetNameFac(){
            _players = null;
        }
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}


	public Command create() throws Exception {
        System.out.print("Please input new name of the current player:- ");
		String heroID = Main.sc.nextLine();

		return new SetName(_players,heroID);
	}
}
