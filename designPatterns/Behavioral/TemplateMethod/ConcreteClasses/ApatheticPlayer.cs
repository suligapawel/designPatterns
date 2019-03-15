using designPatterns.Behavioral.TemplateMethod.Abstracts;
using System;

namespace designPatterns.Behavioral.TemplateMethod.ConcreteClasses
{
    public class ApatheticPlayer : BasePenaltyShooter
    {
        protected override void BeHappy()
        {
            Console.WriteLine("Player is smiling.");
        }

        protected override void BeSad()
        {
            Console.WriteLine("Player has sad face.");
        }

        protected override void SpeedUp()
        {
            base.SpeedUp();
            Console.WriteLine("He stop, looking for goalkeeper...");
        }
    }
}
