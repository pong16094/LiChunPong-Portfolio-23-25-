// PlayerCreateFac.java

import java.util.Vector;

public class PlayerCreateFac implements CommandFactory {
		//public static  Scanner sc = new Scanner(System.in);

		private Vector<Player> _players;
		
		public PlayerCreateFac(){
			_players = null;
		}
	

	public void setPlayers(Vector<Player> players) {
		_players = players;
	}



	public Command create() throws Exception {
		/*InputStreamReader is = new InputStreamReader(System.in);
		BufferedReader br = new BufferedReader(is);*/
		System.out.print("Player ID:- ");	
		String id = Main.sc.nextLine();
		System.out.print("Player Name:- ");
		String name = Main.sc.nextLine();
		return new PlayerCreate(_players,id,name);
	}
}
