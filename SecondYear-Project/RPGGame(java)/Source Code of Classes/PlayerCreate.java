// CircleCreation.java

import java.util.Vector;

public class PlayerCreate implements Command {
	private String _id, _name;
	private Vector<Player> _players;
	private Player _lastPlayer;

	public PlayerCreate(Vector<Player> players,String id, String name) {
		_players =  players;
		_id = id;
		_name = name;
		_lastPlayer = null;
	}

	public void execute() {
		_lastPlayer = Main.currentPlayer;
		Main.currentPlayer = new Player(_id,_name);
		_players.add(Main.currentPlayer);
		System.out.println("Current player is changed to "+ Main.currentPlayer.getPlayerID() + ".\n");
		
	}


	public void undo() {
        if (Main.currentPlayer != null) {
			if (_players.size() == 1) {
			_players.remove(Main.currentPlayer);
            Main.currentPlayer = null;
			_lastPlayer =null;
			return;
			}
            _players.remove(Main.currentPlayer);
            Main.currentPlayer = _lastPlayer;
        } else {
            System.out.println("No current player to undo.\n");
        }
    }

	@Override
    public String getDetails() {
        return "Create player, " + _id + ", " + _name;
    }
}
