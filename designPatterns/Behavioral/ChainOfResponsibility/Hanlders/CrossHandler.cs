using designPatterns.Behavioral.ChainOfResponsibility.Abstracts;
using System;

namespace designPatterns.Behavioral.ChainOfResponsibility.Hanlders
{
    public class CrossHandler : BaseFootballActionHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Footballer cross...");

            base.Handle();
        }
    }
}
