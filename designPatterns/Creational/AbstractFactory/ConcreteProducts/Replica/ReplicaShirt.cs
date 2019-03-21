using designPatterns.Creational.AbstractFactory.Abstracts;

namespace designPatterns.Creational.AbstractFactory.ConcreteProducts.Match
{
    public class ReplicaShirt : IShirtProduct
    {
        public string Textile => "Plastic";

        public decimal Price => 99.99M;

        public bool IsShortSleeve => false;
    }
}
