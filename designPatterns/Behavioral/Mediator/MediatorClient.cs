using designPatterns.Behavioral.Mediator.ConcreteFootballers;
using System;

namespace designPatterns.Behavioral.Mediator
{
    public class MediatorClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START MEDIATOR *****");

            var rumorFootballer = new RumorFootballer();
            var aggressiveFootballer = new AggressiveFootballer();
            var captain = new Captain();

            var mediator = new RumorMediator(rumorFootballer, aggressiveFootballer, captain);
            mediator.Notify(rumorFootballer, "I heared you have ugly wife.");
            mediator.Notify(rumorFootballer, "I heared about your salary. Really you earn 1000000$?");

            mediator.Notify(aggressiveFootballer, "I heared about your new Car.");

            Console.WriteLine("***** END MEDIATOR *****");
        }
    }
}
