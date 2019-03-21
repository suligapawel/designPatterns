using designPatterns.Creational.AbstractFactory.Abstracts;
using designPatterns.Creational.AbstractFactory.ConcreteProducts.Match;

namespace designPatterns.Creational.AbstractFactory.ConcreteFactories
{
    public class MatchOutfit : IOutfitFactory
    {
        public IShirtProduct ProduceShirt() => new MatchShirt();

        public IShortProduct ProduceShort() => new MatchShort();

        public ISocksProduct ProduceSocks() => new MatchSocks();
    }
}
