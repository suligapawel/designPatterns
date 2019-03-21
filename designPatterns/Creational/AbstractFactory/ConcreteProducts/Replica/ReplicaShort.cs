using designPatterns.Creational.AbstractFactory.Abstracts;

namespace designPatterns.Creational.AbstractFactory.ConcreteProducts.Match
{
    public class ReplicaShort : IShortProduct
    {
        public string Textile => "Plastic";

        public decimal Price => 49.99M;

        public string Color => "Light red";
    }
}
