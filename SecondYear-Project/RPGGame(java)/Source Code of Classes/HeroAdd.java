// CircleCreation.java
import java.util.Vector;

public class HeroAdd implements Command {
	Vector<Player> _players;
	Hero _hero;
	Player _player;
	int index = -1;

	public HeroAdd(Vector<Player> players,Hero hero) {
		_players = players;
		_hero = hero;
		_player = null;
	}

	public void execute() {
		index = _players.indexOf(Main.currentPlayer);
		//_hero = new Hero(_id,_name);
		if(index!=-1){
		_players.get(index).addHero(_hero);
        System.out.println("Hero is added.\n");
		}
	}

	public void undo() {
		if (index != -1)
		_players.get(index).removeHero(_hero);
	}

	@Override
    public String getDetails() {
        return "Add hero, " + _hero.getHeroID() + ", " + _hero.getHeroName() + ", " + _hero.getType();
    }
}
