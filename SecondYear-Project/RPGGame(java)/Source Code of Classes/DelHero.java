// CircleCreation.java

import java.util.Vector;

public class DelHero implements Command {
	private Vector<Player> _players;
    private String _heroID;
    private Hero _hero;
    private int index ;

	public DelHero(Vector<Player> players,String heroID) {
		_players =  players;
        _heroID = heroID;
	}

	public void execute() {
        index = _players.indexOf(Main.currentPlayer);
            Player player = _players.elementAt(index);
            Vector<Hero> heros = player.getHeroes();

            for(int y = 0; y<heros.size();y++){
                _hero = heros.elementAt(y);
                if(_hero.getHeroID().equals(_heroID)){
                    
                    _players.elementAt(index).removeHero(_hero);
                    Main.currentPlayer = _players.elementAt(index);
                    System.out.println(_hero.getHeroID() + " " + _hero.getHeroName() + " is deleted.\n");
                    return;
                }
            }//Hero Loop


        System.out.println("cannot find the hero " + _heroID +"\n");

	}

	public void undo() {
        _players.elementAt(index).addHero(_hero);

	}

    @Override
    public String getDetails() {
	return "Delete hero, "+_heroID;
    }
}
