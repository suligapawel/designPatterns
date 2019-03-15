using designPatterns.Behavioral.TemplateMethod.Abstracts;
using System;

namespace designPatterns.Behavioral.TemplateMethod.ConcreteClasses
{
    public class EmotionalPlayer : BasePenaltyShooter
    {
        protected override void BeHappy()
        {
            Console.WriteLine("Player pulls the shirt and runs to the fans.");
        }

        protected override void BeSad()
        {
            Console.WriteLine("Player crying.");
        }
    }
}
