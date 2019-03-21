namespace designPatterns.Creational.AbstractFactory.Abstracts
{
    public interface IOutfitFactory
    {
        IShirtProduct ProduceShirt();
        IShortProduct ProduceShort();
        ISocksProduct ProduceSocks();
    }
}
