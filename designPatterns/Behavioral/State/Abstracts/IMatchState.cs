using System.Threading.Tasks;

namespace designPatterns.Behavioral.State.Abstracts
{
    public interface IMatchState
    {
        Task Run(MatchStatistics dataContext);
    }
}
