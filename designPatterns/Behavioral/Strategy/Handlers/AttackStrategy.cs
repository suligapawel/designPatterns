using designPatterns.Behavioral.Strategy.Abstract;
using System;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    public class AttackStrategy : ITeamStrategy
    {
        public void Play()
        {
            Console.WriteLine("Manager set tactic on 3-4-3. Team now play attack tactic.");
        }
    }
}
