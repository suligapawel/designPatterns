namespace designPatterns.Structural.Decorator.Abstracts
{
    public interface ITicket
    {
        string Name { get; }
        double CalculatePrice();
    }
}
