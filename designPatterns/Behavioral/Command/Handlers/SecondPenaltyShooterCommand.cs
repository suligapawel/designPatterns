using System;
using designPatterns.Behavioral.Command.Abstracts;

namespace designPatterns.Behavioral.Command.Handlers
{
    public class SecondPenaltyShooterCommand : IFootballerCommand
    {
        private bool _scoredGoal = false;

        public void Shoot()
        {
            TakeFewSteps();
            StopToMisleadGoolkeeper();
            ShootInLeftCorner();

            _scoredGoal = true;
        }

        private void TakeFewSteps()
        {
            Console.WriteLine("Player is taking run up and...");
        }

        private void StopToMisleadGoolkeeper()
        {
            Console.WriteLine("...is stopping and...");
        }

        private void ShootInLeftCorner()
        {
            Console.WriteLine("...shooting in left corner.");
        }

        public void Back()
        {
            _scoredGoal = false;
            Console.WriteLine("Referee decides to renew penalty!");
        }
    }
}