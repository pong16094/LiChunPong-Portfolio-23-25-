public class WarriorFactory implements HeroFactory {
    @Override
    public Hero createHero(String id, String name) {
        return new Warrior(id,name);
    }
}