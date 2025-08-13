// CircleCreation.java

import java.util.Vector;

public class ShowPlayer implements Command {
	private Vector<Player> _players;
	private Player _player;

	public ShowPlayer(Player player) {
		_players =  null;
		_player = player;
	}

	public void execute() {
		_player.showPlayerDetails();
		System.out.println();
		
	}

	public void undo() {
	}
	
	@Override
    public String getDetails() {
	return null;
    }
}
