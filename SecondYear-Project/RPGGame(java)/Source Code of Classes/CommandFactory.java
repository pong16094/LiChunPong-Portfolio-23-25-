	// CommandFactory.java

import java.util.Vector;

public interface CommandFactory {
	abstract public void setPlayers(Vector<Player> player);
	abstract public Command create() throws Exception;
}
