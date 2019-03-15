using designPatterns.Behavioral.Strategy.Abstract;
using System;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    public class DefenseStrategy : ITeamStrategy
    {
        public void Play()
        {
            Console.WriteLine("Manager set tactic on 5-3-2. Team now play defense tactic.");
        }
    }
}
