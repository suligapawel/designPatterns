using designPatterns.Behavioral.Mediator.Abstracts;
using designPatterns.Behavioral.Mediator.ConcreteFootballers;

namespace designPatterns.Behavioral.Mediator
{
    public class RumorMediator : IRumorMediator
    {
        private readonly RumorFootballer _rumorFootballer;
        private readonly AggressiveFootballer _aggresiveFootballer;
        private readonly Captain _captain;

        public RumorMediator(RumorFootballer rumorFootballer, AggressiveFootballer agressiveFootballer, Captain captain)
        {
            _rumorFootballer = rumorFootballer;
            _rumorFootballer.SetMediator(this);
            _aggresiveFootballer = agressiveFootballer;
            _aggresiveFootballer.SetMediator(this);
            _captain = captain;
            _captain.SetMediator(this);
        }

        public void Notify(BaseFootballer footballer, string rumor)
        {
            if (footballer is RumorFootballer && rumor.Contains("wife"))
            {
                _aggresiveFootballer.ReactOnRumor(rumor);
                return;
            }
            else if (footballer is RumorFootballer)
            {
                _aggresiveFootballer.ReactOnRumor(rumor);
                _captain.ReactOnRumor(rumor);
                return;
            }
            else
            {
                _captain.ReactOnRumor(rumor);
                _rumorFootballer.ReactOnRumor(rumor);
                return;
            }
        }
    }
}
