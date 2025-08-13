// Command.java
public interface Command {
	abstract public void execute();
	abstract public void undo();
	abstract public String getDetails();
}
