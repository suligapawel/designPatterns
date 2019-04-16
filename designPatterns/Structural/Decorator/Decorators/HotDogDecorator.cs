using designPatterns.Structural.Decorator.Abstracts;

namespace designPatterns.Structural.Decorator.Decorators
{
    public class HotDogDecorator : BaseTicketDecorator
    {
        public HotDogDecorator(ITicket ticket) : base(ticket) { }

        public override string Name => base.Name + ", hot-dog";

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 3.99;
        }
    }
}
