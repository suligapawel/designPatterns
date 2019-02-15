using designPatterns.Behavioral.State.Abstracts;
using System;
using System.Threading.Tasks;

namespace designPatterns.Behavioral.State
{
    public class MatchContext
    {
        private readonly MatchStatistics _dataContext = new MatchStatistics();
        private IMatchState _matchState;

        public MatchContext(IMatchState firstState)
        {
            _matchState = firstState;
        }

        public MatchContext SetNextState(IMatchState nextState)
        {
            Console.WriteLine("-- STATE HAS CHANGED --");
            _matchState = nextState;

            return this;
        }

        private void InitNextState(IMatchState state)
        {
            _matchState = state;
        }

        public async Task RunNextState()
        {
            await _matchState.Run(_dataContext);
        }

        public void ShowResult()
        {
            _dataContext.ShowResult();
        }
    }
}
