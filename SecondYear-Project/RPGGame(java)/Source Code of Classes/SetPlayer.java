// CircleCreation.java

import java.util.Vector;

public class SetPlayer implements Command {
	private Vector<Player> _players;
    private String _playerID;
    private Player _player;

	public SetPlayer(Vector<Player> players,String playerID) {
		_players =  players;
        _playerID = playerID;
	}

	public void execute() {
        for(int i = 0; i<_players.size();i++){
            Player player = _players.elementAt(i);
            if(player.getPlayerID().equals(_playerID)){
                _player = Main.currentPlayer;
                Main.currentPlayer=player;
                System.out.println("Changed current player to " + player.getPlayerID()+"\n");
                return;
            }
        }
        System.out.println("cannot find the user " + _playerID +"\n");

	}

	public void undo() {
        Main.currentPlayer = _player;
	}

    @Override
    public String getDetails() {//may be should do the undo
	return null;
    }
}
