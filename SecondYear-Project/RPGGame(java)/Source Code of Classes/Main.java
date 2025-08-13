
// Main.java
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.Stack;
import java.util.Vector;

public class Main {
	public static Scanner sc = new Scanner(System.in);
	public static Player currentPlayer;
	// public static Stack _undoList = new LinkedList();

	public static void main(String[] args) {
		Map<String, Integer> action = new HashMap<String, Integer>();
		Vector<Player> _players = new Vector<Player>();
		String[] key = { "c", "g", "a", "m", "d", "s", "p", "t" };
		String[] _factory = { "PlayerCreateFac", "SetPlayerFac", "HeroAddFac", "CallSkillFac", "DelHeroFac",
				"ShowPlayerFac", "AllPlayerFac", "SetNameFac" };
		CommandFactory[] _facs;
		boolean cont = true;
		Stack<Command> undoStack = new Stack<>();
		Stack<Command> redoStack = new Stack<>();

		_facs = new CommandFactory[_factory.length];
		for (int i = 0; i < key.length; i++) {
			action.put(key[i], i);
		}
		String line;

		try {
			for (int i = 0; i < _facs.length; i++) {
				_facs[i] = (CommandFactory) Class.forName(_factory[i]).newInstance();
				_facs[i].setPlayers(_players);
			}
			while (cont) {
				System.out.println("Fantastic World (FW)");
				System.out.println("Commands: c = create player, g = set current player, a = add hero, " +
						"m = call hero skill, d = delete hero, s = show player, " +
						"p = display all players, t = change player’s name, " +
						"u = undo, r = redo, l = list undo/redo, x = exit system");
				if (currentPlayer != null) {
					System.out.println("The current player is " + currentPlayer.getPlayerID() + " "
							+ currentPlayer.getPlayerName() + ".");
				}

				System.out.print("Please enter command [ c | g | a | m | d | s | p | t | u | r | l | x ] :-");
				line = sc.nextLine().toLowerCase();

				if (line.equals("x")) {
					cont = false;
				}
				// undo
				else if (line.equals("u")) {
					if (!undoStack.isEmpty()) {
						Command com = undoStack.pop();
						com.undo();
						System.out.println("Command (" + com.getDetails() + ") is undone\n");

						redoStack.push(com); // Move to redo stack
					}
				}
				// list undo & redo list
				else if (line.equals("l")) {
					System.out.println("Undo List");
					for (Command command : undoStack) {
						System.out.println(command.getDetails());
					}
					System.out.println("-- End of undo list --");

					System.out.println("Redo List");
					for (Command command : redoStack) {
						System.out.println(command.getDetails());
					}
					System.out.println("-- End of redo list --\n");
				}
				// redo
				else if (line.equals("r")) {
					if (!redoStack.isEmpty()) {
						Command command = redoStack.pop();
						command.execute();
						System.out.println("Command (" + command.getDetails() + ") is redone\n");
						undoStack.push(command); // Push the redone command back onto undo stack
					}
				}
				// other option
				else if (action.containsKey(line)) {
					if ((currentPlayer == null) && (line != "c")) {
						System.out.println("Please crate player first\n");
						continue;
					}

					Command com = _facs[action.get(line)].create();
					com.execute(); // Execute the command
					if (!(com instanceof ShowPlayer) && !(com instanceof AllPlayer) && !(com instanceof SetPlayer)) {
						undoStack.push(com); // Push to undoStack after execution
					}

				} else {
					continue;
				}

			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
