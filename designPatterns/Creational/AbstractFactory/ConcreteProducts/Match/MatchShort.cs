using designPatterns.Creational.AbstractFactory.Abstracts;

namespace designPatterns.Creational.AbstractFactory.ConcreteProducts.Match
{
    public class MatchShort : IShortProduct
    {
        public string Textile => "Cotton";

        public decimal Price => 99.99M;

        public string Color => "Red";
    }
}
