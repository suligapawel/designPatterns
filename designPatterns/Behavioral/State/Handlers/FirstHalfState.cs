using designPatterns.Behavioral.State.Abstracts;
using System.Threading.Tasks;

namespace designPatterns.Behavioral.State.Handlers
{
    public class FirstHalfState : IMatchState
    {
        public async Task Run(MatchStatistics dataContext)
        {
            await Task.Run(() =>
            {
                dataContext.AddShooter("Messi", 2);
                dataContext.AddShooter("C.Ronaldo", 15);
                dataContext.AddScorer("C.Ronaldo", 15);
                dataContext.AddShooter("Messi", 30);
                dataContext.AddShooter("Messi", 35);
                dataContext.AddShooter("C.Ronaldo", 45);
                dataContext.AddScorer("C.Ronaldo", 45);
            });
        }
    }
}
