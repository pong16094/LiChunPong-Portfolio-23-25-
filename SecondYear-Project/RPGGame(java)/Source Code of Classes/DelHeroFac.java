// PlayerCreateFac.java

import java.util.Vector;

public class DelHeroFac implements CommandFactory {

		private Vector<Player> _players;
	
        public DelHeroFac(){
            _players = null;
        }
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}


	public Command create() throws Exception {
        System.out.print("Please input hero ID:- ");
		String heroID = Main.sc.nextLine();

		return new DelHero(_players,heroID);
	}
}
