using designPatterns.Behavioral.State.Handlers;

namespace designPatterns.Behavioral.State
{
    public class StateClient : IClient
    {
        public async void RunClientCode()
        {
            var match = new MatchContext(new FirstHalfState());
            await match.RunNextState();

            await match
                .SetNextState(new BreakCompetetions())
                .RunNextState();

            await match
                .SetNextState(new SecondHalfState())
                .RunNextState();

            match.ShowResult();
        }
    }
}
