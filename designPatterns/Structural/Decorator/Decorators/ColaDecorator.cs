using designPatterns.Structural.Decorator.Abstracts;

namespace designPatterns.Structural.Decorator.Decorators
{
    public class ColaDecorator : BaseTicketDecorator
    {
        public ColaDecorator(ITicket ticket) : base(ticket) { }

        public override string Name => base.Name + ", cola";

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 1.99;
        }
    }
}
