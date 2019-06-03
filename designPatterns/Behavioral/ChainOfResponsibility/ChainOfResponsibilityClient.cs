using designPatterns.Behavioral.ChainOfResponsibility.Hanlders;
using System;

namespace designPatterns.Behavioral.ChainOfResponsibility
{
    public class ChainOfResponsibilityClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START CHAIN OF RESPONSIBILITY *****");
            var root = new PassHandler();

            root
                .SetNext(new PassHandler())
                .SetNext(new PassHandler())
                .SetNext(new PassHandler())
                .SetNext(new CrossHandler())
                .SetNext(new ShootHandler())
                .SetNext(new GoalHandler());

            Console.WriteLine("***** END CHAIN OF RESPONSIBILITY *****");
        }
    }
}