using System;

namespace designPatterns.Structural.Facade.Subclasses
{
    public class WarmupTrainer
    {
        public void WarmUpPlayer(Footballer footballer)
        {
            Console.WriteLine($"Warm up player with number {footballer.Number}.");
        }
    }
}