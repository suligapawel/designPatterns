using designPatterns.Structural.Decorator.Abstracts;

namespace designPatterns.Structural.Decorator.Decorators
{
    public class SportGadgetDecorator : BaseTicketDecorator
    {
        public SportGadgetDecorator(ITicket ticket) : base(ticket) { }

        public override string Name => base.Name + ", sport gadget";

        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 29.99;
        }
    }
}
