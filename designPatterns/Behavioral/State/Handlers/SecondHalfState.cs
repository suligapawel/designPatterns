using designPatterns.Behavioral.State.Abstracts;
using System.Threading.Tasks;

namespace designPatterns.Behavioral.State.Handlers
{
    public class SecondHalfState : IMatchState
    {
        public async Task Run(MatchStatistics dataContext)
        {
            await Task.Run(() =>
            {
                dataContext.AddShooter("Messi", 48);
                dataContext.AddShooter("C.Ronaldo", 62);
                dataContext.AddScorer("C.Ronaldo", 62);
                dataContext.AddShooter("Messi", 72);
                dataContext.AddShooter("Messi", 72);
                dataContext.AddShooter("C.Ronaldo", 90);
            });
        }
    }
}
