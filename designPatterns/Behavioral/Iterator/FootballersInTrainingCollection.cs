using designPatterns.Behavioral.Iterator.Abstracts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace designPatterns.Behavioral.Iterator
{
    public class FootballersInTrainingCollection : IAggregate
    {
        private readonly IEnumerable<string> _footballers;
        private bool _firstTeamChoice;

        public FootballersInTrainingCollection(IEnumerable<string> footballers)
        {
            _footballers = footballers;
        }

        public int Count() => _footballers.Count();
        public IEnumerator GetEnumerator() => new EverySecondIterator(this, _firstTeamChoice);
        public List<string> GetItems() => _footballers.ToList();

        public void FirstTeamChoice()
        {
            _firstTeamChoice = true;
        }
    }
}
