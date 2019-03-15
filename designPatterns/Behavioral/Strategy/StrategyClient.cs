using designPatterns.Behavioral.Strategy.Abstract;
using designPatterns.Behavioral.Strategy.Handlers;
using System;

namespace designPatterns.Behavioral.Strategy
{
    public class StrategyClient : IClient
    {
        private readonly ITeamStrategy[] _strategies;

        public StrategyClient()
        {
            _strategies = new ITeamStrategy[3]
                {
                    new DefenseStrategy(),
                    new MiddleStrategy(),
                    new AttackStrategy()
                };
        }
        public void RunClientCode()
        {
            ContextStrategy context = new ContextStrategy();

            context.SetStrategy(_strategies[1]);
            context.PlayWithSetStrategy();
            Console.WriteLine("Oh no. Team lost goal. Result on the board is 0:1.");

            context.SetStrategy(_strategies[2]);
            context.PlayWithSetStrategy();
            Console.WriteLine("YES!! Team scored goal. Result on the board is 1:1.");
            context.PlayWithSetStrategy();
            Console.WriteLine("YES!! Team scored goal. Result on the board is 2:1.");

            context.SetStrategy(_strategies[0]);
            context.PlayWithSetStrategy();
            Console.WriteLine("End Match. Result is 2:1");
        }
    }
}
