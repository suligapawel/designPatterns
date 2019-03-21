using designPatterns.Creational.AbstractFactory.Abstracts;

namespace designPatterns.Creational.AbstractFactory.ConcreteProducts.Match
{
    public class MatchSocks : ISocksProduct
    {
        public decimal Price => 19.99M;

        public int Size => 42;
    }
}
