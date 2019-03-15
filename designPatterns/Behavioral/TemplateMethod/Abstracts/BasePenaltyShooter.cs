using System;

namespace designPatterns.Behavioral.TemplateMethod.Abstracts
{
    public abstract class BasePenaltyShooter
    {
        public bool ShootPenalty()
        {
            WaitForWhistle();
            SpeedUp();

            bool isScored = Shoot();

            if (isScored)
            {
                Console.WriteLine("GOAL!!!");
                BeHappy();
            }
            else
            {
                Console.WriteLine("NO GOAL!");
                BeSad();
            }

            return isScored;
        }

        protected void WaitForWhistle()
        {
            Console.WriteLine("Player waiting for whistle...");
        }

        protected virtual void SpeedUp()
        {
            Console.WriteLine("speeding up...");
        }

        protected bool Shoot()
        {
            var random = new Random();
            Console.WriteLine("shooting...");

            return random.Next(0, 2) == 1;
        }

        protected abstract void BeHappy();
        protected abstract void BeSad();
    }
}
