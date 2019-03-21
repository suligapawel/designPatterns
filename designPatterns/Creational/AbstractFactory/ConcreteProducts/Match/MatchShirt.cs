using designPatterns.Creational.AbstractFactory.Abstracts;

namespace designPatterns.Creational.AbstractFactory.ConcreteProducts.Match
{
    public class MatchShirt : IShirtProduct
    {
        public string Textile => "Cotton";

        public decimal Price => 299.99M;

        public bool IsShortSleeve => true;
    }
}
