using System;
using designPatterns.Behavioral.Observer.Abstracts;

namespace designPatterns.Behavioral.Observer.Subscribers
{
    public class FanSubscriber : ISubscriber
    {
        private const string FAN = "Fan";

        public string Team { get; private set; }

        public string Type { get; private set; }

        public FanSubscriber(string team)
        {
            Team = team;
            Type = FAN;
        }
        public bool SendMessage(YoungFootballerSubject subject)
        {
            if (subject.GoodMatches > 4)
            {
                Console.WriteLine("Fan hang a poster on the wall");
            }

            return true;
        }
    }
}