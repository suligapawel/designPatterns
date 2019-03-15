using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Abstract
{
    public interface ITeamStrategy
    {
        void Play(IEnumerable<Player> players);
    }
}
