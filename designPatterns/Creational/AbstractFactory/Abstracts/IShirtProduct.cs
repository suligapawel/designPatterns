namespace designPatterns.Creational.AbstractFactory.Abstracts
{
    public interface IShirtProduct
    {
        string Textile { get; }
        decimal Price { get; }
        bool IsShortSleeve { get; }
    }
}
