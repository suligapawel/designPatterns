using designPatterns.Behavioral.Strategy.Abstract;
using System;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    class MiddleStrategy : ITeamStrategy
    {
        public void Play()
        {
            Console.WriteLine("Manager set tactic on 4-4-2. Team now play middle tactic.");
        }
    }
}
