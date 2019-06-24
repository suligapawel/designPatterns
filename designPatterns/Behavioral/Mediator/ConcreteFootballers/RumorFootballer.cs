using designPatterns.Behavioral.Mediator.Abstracts;

namespace designPatterns.Behavioral.Mediator.ConcreteFootballers
{
    public class RumorFootballer : BaseFootballer
    {
        public override void ReactOnRumor(string rumor)
        {
            _rumorMediator.Notify(this, rumor);
        }
    }
}
