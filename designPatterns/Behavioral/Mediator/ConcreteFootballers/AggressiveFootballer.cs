using designPatterns.Behavioral.Mediator.Abstracts;
using System;

namespace designPatterns.Behavioral.Mediator.ConcreteFootballers
{
    public class AggressiveFootballer : BaseFootballer
    {
        public override void ReactOnRumor(string rumor)
        {
            string newRumor = $"Footballer beat a friend on the training by {rumor}";

            Console.WriteLine(newRumor);
        }
    }
}
