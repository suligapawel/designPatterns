using designPatterns.Creational.AbstractFactory.Abstracts;

namespace designPatterns.Creational.AbstractFactory.ConcreteProducts.Match
{
    public class ReplicaSocks : ISocksProduct
    {
        public decimal Price => 9.99M;

        public int Size => 36;
    }
}
