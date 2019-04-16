namespace designPatterns.Structural.Decorator.Abstracts
{
    public abstract class BaseTicketDecorator : ITicket
    {
        protected readonly ITicket _ticket;

        public BaseTicketDecorator(ITicket ticket)
        {
            _ticket = ticket;
        }

        public virtual string Name => _ticket.Name;

        public virtual double CalculatePrice()
        {
            return _ticket.CalculatePrice();
        }
    }
}
