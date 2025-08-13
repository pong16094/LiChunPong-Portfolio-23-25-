// PlayerCreateFac.java
import java.util.Vector;

public class HeroAddFac implements CommandFactory {
	private Vector<Player> _players;
    private String[] _heroType = {"WarriorFactory", "WarlockFactory"};
    private HeroFactory[] _heros;

	public HeroAddFac() {
        _players = null;
        _heros = new HeroFactory[_heroType.length];
        // Populate factoryMap using a loop
        for (int i = 0; i < _heroType.length; i++) {
            try {
                // Instantiate factory class using reflection
                _heros[i] = (HeroFactory) Class.forName(_heroType[i]).newInstance();
            }
			catch (InstantiationException | IllegalAccessException | ClassNotFoundException e) {
                e.printStackTrace();
            }
        }
    }




	public void setPlayers(Vector<Player> players) {
		_players = players;
	}

	public Command create() throws Exception {//not finsih

        String[] strings = null;

        while (true) {
            System.out.print("Please input hero information (id, name):- ");
            String heroDetail = Main.sc.nextLine();
            strings = heroDetail.split(",");
    
            // Check if the input is valid (exactly 2 parts)
            if (strings.length != 2) {
                System.out.println("Invalid input. Please enter id and name separated by a comma.");
                continue; // Prompt for input again
            }
            
    
            String id = strings[0].trim();  // Remove leading/trailing whitespace
            String name = strings[1].trim();
    
            System.out.print("Hero Type (1 = Warrior | 2 = Warlock ):-");
            int type = Main.sc.nextInt();
            Main.sc.nextLine();
            Hero h1 = _heros[type-1].createHero(id,name);
            return new HeroAdd(_players,h1);
        }
        
	
	}

        //return Class.forName(Type[type-1]).newInstance(_players,_player, id,name);
	
	
}
