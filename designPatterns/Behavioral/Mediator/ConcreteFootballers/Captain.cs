using designPatterns.Behavioral.Mediator.Abstracts;
using System;

namespace designPatterns.Behavioral.Mediator.ConcreteFootballers
{
    public class Captain : BaseFootballer
    {
        public override void ReactOnRumor(string rumor)
        {
            Console.WriteLine("Focus on the next Match!");
        }
    }
}
