// CircleCreation.java

import java.util.Vector;

public class CallSkill implements Command {
	private Vector<Player> _players;
    private String _heroID;
    private Hero _hero;
    private Caretaker caretaker;

	public CallSkill(Vector<Player> players,String heroID) {
		_players =  players;
        _heroID = heroID;
        caretaker = new Caretaker();
	}

	public void execute() {
        int index = _players.indexOf(Main.currentPlayer);
            Player player = _players.elementAt(index);
            Vector<Hero> heros = player.getHeroes();

            for(int y = 0; y<heros.size();y++){
                _hero = heros.elementAt(y);

                if(_hero.getHeroID().equals(_heroID)){
                    caretaker.saveHero(_players.elementAt(index),index);
                    _players.elementAt(index).getHeroes().elementAt(y).callSkill();
                    System.out.println(_hero.getHeroID() + " " + _hero.getHeroName() + "’s attributes are changed to:\n");
                    System.out.println(_hero.showHeroStatus()+"\n");
                    _hero = _players.elementAt(index).getHeroes().elementAt(y);
                    Main.currentPlayer = _players.elementAt(index);
                    return;
                }
            }//Hero Loop


        
        System.out.println("cannot find the hero " + _heroID +"\n");

	}

	public void undo() {
        caretaker.undo();
	}

    @Override
    public String getDetails() {
        return "Call hero skill, " + _hero.showHeroStatus();
    }
}
