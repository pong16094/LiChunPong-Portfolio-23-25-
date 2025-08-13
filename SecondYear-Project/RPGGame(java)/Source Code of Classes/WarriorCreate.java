// CircleCreation.java
import java.util.Vector;

public class WarriorCreate implements Command {
	String _id, _name;
	Vector _players;
    Player _player;
	Hero _hero;
    String[] Type= {"Warrior","Warlock"};
    String _type;

	public WarriorCreate(Vector players,Player player, String id, String name,int type) {
        _players = players;
        _player = player;
		_id = id;
		_name = name;
		_hero = null;
        _type = Type[type];
	}

	public void execute() {
		_hero = new Warrior(_id,_name);
		_player.addHero(_hero);;
        System.out.println(_id);
	}

	public void undo() {
		if (_hero != null)
			_player.removeHero(_hero);
	}
	@Override
    public String getDetails() {
	return null;
    }
}
