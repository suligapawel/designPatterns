using designPatterns.Behavioral.ChainOfResponsibility.Abstracts;
using System;

namespace designPatterns.Behavioral.ChainOfResponsibility.Hanlders
{
    public class GoalHandler : BaseFootballActionHandler
    {
        public override void Handle()
        {
            Console.WriteLine("GOAL!!!");

            base.Handle();
        }
    }
}
