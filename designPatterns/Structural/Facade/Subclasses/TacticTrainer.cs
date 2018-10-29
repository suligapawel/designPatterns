using System;

namespace designPatterns.Structural.Facade.Subclasses
{
    public class TacticTrainer
    {
        public void ExplainTactic(Footballer footballer)
        {
            Console.WriteLine($"Explaint Tactic player with number {footballer.Number}.");
        }
    }
}