using System;
using designPatterns.Behavioral.Observer.Abstracts;
using designPatterns.Behavioral.Observer.Subscribers;

namespace designPatterns.Behavioral.Observer
{
    public class ObserverClient
    {
        private delegate IYoungFootballerSubject _playMatchDelegate();

        public void RunClientCode()
        {
            Console.WriteLine("***** START OBSERVER *****");
            int i = 3;

            IYoungFootballerSubject observer = new YoungFootballerSubject();

            var matches = new _playMatchDelegate(observer.PlayBadMatch);

            while (i-- > 0)
            {
                matches += observer.PlayGoodMatch;
            }

            observer.AddObserver(new ScoutSubscriber("Ajax Amsterdam", 7, 5));
            observer.AddObserver(new FanSubscriber("Lech Poznan"));
            observer.AddObserver(new ScoutSubscriber("FC Barcelona", 1, 20));

            matches();

            Console.WriteLine("--- FIRST NOTIFY ---");
            observer.NotifyObservers();

            matches -= observer.PlayGoodMatch;
            matches();

            Console.WriteLine("--- SECOND NOTIFY ---");
            observer.NotifyObservers();

            i = 5;
            while (i-- > 0)
            {
                matches -= observer.PlayGoodMatch;
                matches += observer.PlayBadMatch;
            }
            matches();

            Console.WriteLine("--- THIRD NOTIFY ---");
            observer.NotifyObservers();

            Console.WriteLine("***** END OBSERVER *****");
        }
    }
}