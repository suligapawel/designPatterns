using designPatterns.Behavioral.ChainOfResponsibility.Abstracts;
using System;

namespace designPatterns.Behavioral.ChainOfResponsibility.Hanlders
{
    public class PassHandler : BaseFootballActionHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Footballer pass...");

            base.Handle();
        }
    }
}
