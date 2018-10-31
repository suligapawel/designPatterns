using System;
using System.Collections.Generic;
using designPatterns.Behavioral.Observer.Abstracts;

namespace designPatterns.Behavioral.Observer
{
    public class YoungFootballerSubject : IYoungFootballerSubject
    {
        private readonly List<ISubscriber> _subscribers;
        public int GoodMatches { get; protected set; }
        public int BadMatches { get; protected set; }

        public YoungFootballerSubject()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void AddObserver(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            Console.WriteLine($"{subscriber.Type} from {subscriber.Team} watching the player.");
        }

        public void NotifyObservers()
        {
            ISubscriber subscriber;

            for (var i = 0; i < _subscribers.Count; i++)
            {
                subscriber = _subscribers[i];

                bool isInteresting = subscriber.SendMessage(this);

                if (!isInteresting)
                {
                    _subscribers.Remove(subscriber);
                    Console.WriteLine($"{subscriber.Type} from {subscriber.Team} non watching the player.");
                }
            }

            Console.WriteLine($"Sum of subscribers: {_subscribers.Count}");
        }

        public IYoungFootballerSubject PlayGoodMatch()
        {
            GoodMatches++;
            return this;
        }

        public IYoungFootballerSubject PlayBadMatch()
        {
            BadMatches++;
            return this;
        }
    }
}