using System.Collections;
using designPatterns.Behavioral.Iterator.Abstracts;

namespace designPatterns.Behavioral.Iterator
{
    public class EverySecondIterator : IEnumerator
    {
        private readonly IAggregate _aggregate;
        private int _currentIndex = -2;

        public EverySecondIterator(IAggregate aggragate, bool firstTeamChoice)
        {
            _aggregate = aggragate;

            if (firstTeamChoice)
                _currentIndex = -1;
        }

        object IEnumerator.Current => _aggregate.GetItems()[_currentIndex];

        public bool MoveNext()
        {
            _currentIndex += 2;
            return _currentIndex < _aggregate.Count();
        }

        public void Reset()
        {
            _currentIndex = -2;
        }
    }
}
