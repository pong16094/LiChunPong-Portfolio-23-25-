// CircleCreation.java

import java.util.Vector;

public class SetName implements Command {
	private Vector<Player> _players;
    private String _playerName;
    private int index;
    private Caretaker caretaker;


	public SetName(Vector<Player> players,String playerName) {
		_players =  players;
        _playerName = playerName;
        caretaker = new Caretaker();
	}

	public void execute() {
            index = _players.indexOf(Main.currentPlayer);
            if(index != -1){
            //_oldName = _players.elementAt(index).getPlayerName();
            caretaker.savePlayerID(Main.currentPlayer);

            _players.elementAt(index).setPlayerName(_playerName);
            Main.currentPlayer = _players.elementAt(index);
            
            System.out.println("Player’s name is updated.\n");
            return;
            }
	}

	public void undo() {
        caretaker.undo();
	}

    @Override
    public String getDetails() {
        return "Change player’s name, " + Main.currentPlayer.getPlayerID() + ", " + _playerName;
    }
}
