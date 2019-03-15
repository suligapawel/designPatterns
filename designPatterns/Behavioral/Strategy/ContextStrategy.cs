using designPatterns.Behavioral.Strategy.Abstract;

namespace designPatterns.Behavioral.Strategy
{
    public class ContextStrategy
    {
        private ITeamStrategy _strategy;

        public void SetStrategy(ITeamStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PlayWithSetStrategy()
        {
            _strategy.Play();
        }
    }
}
