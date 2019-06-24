namespace designPatterns.Behavioral.Mediator.Abstracts
{
    public abstract class BaseFootballer
    {
        protected IRumorMediator _rumorMediator;

        public BaseFootballer() { }

        public void SetMediator(IRumorMediator mediator) => _rumorMediator = mediator;

        public abstract void ReactOnRumor(string rumor);
    }
}
