using System;
using designPatterns.Behavioral.Observer.Abstracts;

namespace designPatterns.Behavioral.Observer.Subscribers
{
    public class ScoutSubscriber : ISubscriber
    {
        private const string SCOUT = "Scout";
        private readonly int _maxBadMatches;
        private readonly int _maxGoodMatches;

        public string Team { get; private set; }
        public string Type { get; private set; }

        public ScoutSubscriber(string team, int maxBadMatches, int maxGoodMatches)
        {
            Team = team;
            Type = SCOUT;
            _maxBadMatches = maxBadMatches;
            _maxGoodMatches = maxGoodMatches;
        }

        public bool SendMessage(YoungFootballerSubject subject)
        {
            if (subject.BadMatches > _maxBadMatches)
            {
                Console.WriteLine($"Scout from {Team} is not interesting.");
                return false;
            }

            int interesedPercent = (int)((double)subject.GoodMatches / _maxGoodMatches * 100);

            if (interesedPercent > 50 && interesedPercent < 75)
            {
                Console.WriteLine($"Scout from {Team} is little interesting.");
            }

            if (interesedPercent > 75)
            {
                Console.WriteLine($"Scout from {Team} is very interesting.");
            }

            return true;
        }
    }
}