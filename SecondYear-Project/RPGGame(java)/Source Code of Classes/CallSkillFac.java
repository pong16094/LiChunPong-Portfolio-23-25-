// PlayerCreateFac.java

import java.util.Vector;

public class CallSkillFac implements CommandFactory {

		private Vector<Player> _players;
	
        public CallSkillFac(){
            _players = null;
        }
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}


	public Command create() throws Exception {
        System.out.print("Please input hero ID:- ");
		String heroID = Main.sc.nextLine();

		return new CallSkill(_players,heroID);
	}
}
