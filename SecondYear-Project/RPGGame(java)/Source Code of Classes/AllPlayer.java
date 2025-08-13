// CircleCreation.java

import java.util.Vector;

public class AllPlayer implements Command {
	private Vector<Player> _players;
	private Player _player;

	public AllPlayer(Vector<Player> players) {
		_players =  players;
		_player = null;
	}

	public void execute() {
        for(int i = 0; i<_players.size();i++){
            _player = _players.elementAt(i);
            System.out.println("Player " + _player.getPlayerName() + " (" + _player.getPlayerID()  +")\n");
        }
	}
	@Override
    public void undo() {
    }

	@Override
    public String getDetails() {
	return null;
    }
}
