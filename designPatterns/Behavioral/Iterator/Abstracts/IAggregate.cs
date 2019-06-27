using System.Collections;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Iterator.Abstracts
{
    public interface IAggregate : IEnumerable
    {
        List<string> GetItems();
        int Count();
        void FirstTeamChoice();
    }
}
