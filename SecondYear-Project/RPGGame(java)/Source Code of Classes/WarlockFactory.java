public class WarlockFactory implements HeroFactory {
    @Override
    public Hero createHero(String id, String name) {
        return new Warlock(id, name);
    }
}