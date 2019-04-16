using designPatterns.Structural.Decorator.Abstracts;

namespace designPatterns.Structural.Decorator
{
    public class SimpleTicket : ITicket
    {
        public string Name => "Simple ticket";

        public double CalculatePrice()
        {
            return 15.99;
        }
    }
}
