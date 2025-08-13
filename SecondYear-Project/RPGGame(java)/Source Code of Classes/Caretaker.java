import java.util.Vector;

public class Caretaker {
    Vector undoList;

     public Caretaker() {
        undoList = new Vector<>();
    }
     public void savePlayerID(Player xaccount) {
        PlayerIDMemento a = new PlayerIDMemento(xaccount);
            undoList.addElement(a);
     }

     public void saveHero(Player xplayer,int xheroIndex) {
        HeroMemento a = new HeroMemento(xplayer,xheroIndex);
            undoList.addElement(a);
     }


     public void undo() {
          if (undoList.size() > 0) {
              // get the last element in the undo list
              Object obj = undoList.lastElement();
              Memento m = (Memento) obj;
              m.restore(); // restore the state of the orginator
              undoList.removeElement(obj);
          } // if end
     } // undo
     
}