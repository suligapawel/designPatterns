using System;
using designPatterns.Behavioral.Command.Abstracts;

namespace designPatterns.Behavioral.Command.Handlers
{
    public class FirstPenaltyShooterCommand : IFootballerCommand
    {
        private bool _scoredGoal = false;

        public void Shoot()
        {
            GetFocus();
            ShootInLeftCorner();

            _scoredGoal = true;

            if (_scoredGoal)
                Console.WriteLine("Player scored goal!!!");
        }


        private void GetFocus()
        {
            Console.WriteLine("Player is focusing and...");
        }

        private void ShootInLeftCorner()
        {
            Console.WriteLine("...shooting in right corner.");
        }

        public void Back()
        {
            _scoredGoal = false;
            if (!_scoredGoal)
                Console.WriteLine("Referee decides to renew penalty!");
        }
    }
}