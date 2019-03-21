using designPatterns.Creational.AbstractFactory.Abstracts;
using designPatterns.Creational.AbstractFactory.ConcreteProducts.Match;

namespace designPatterns.Creational.AbstractFactory.ConcreteFactories
{
    public class ReplicaOutfit : IOutfitFactory
    {
        public IShirtProduct ProduceShirt() => new ReplicaShirt();
                                                   
        public IShortProduct ProduceShort() => new ReplicaShort();
                                                   
        public ISocksProduct ProduceSocks() => new ReplicaSocks();
    }
}
