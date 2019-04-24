using designPatterns.Structural.Proxy.Abstracts;
using System;

namespace designPatterns.Structural.Proxy
{
    public class ManagerProxy : ISalary
    {
        private readonly ISalary _footballerSalary;

        private readonly int _goals;
        private readonly int _cards;

        public ManagerProxy(int goals, int cards)
        {
            _goals = goals;
            _cards = cards;

            _footballerSalary = new FootballerSalary(goals > 0, cards > 0);
        }

        public decimal WithdrawPayment()
        {
            decimal payment = _footballerSalary.WithdrawPayment();

            payment = SubstractForGoals(payment);
            payment = SubstractForCards(payment);

            return payment;
        }
      
        private decimal SubstractForGoals(decimal payment)
        {
            if (_goals < 5)
            {
                const decimal penalty = 1000m;

                payment -= penalty;
                Console.WriteLine($"Manager substract penalty for goals - {penalty:C}");
            }

            return payment;
        }

        private decimal SubstractForCards(decimal payment)
        {
            if (_cards > 2)
            {
                const decimal penalty = 2000m;

                payment -= 2000m;
                Console.WriteLine($"Manager substract penalty for cards - {penalty:C}");
            }

            return payment;
        }
    }
}
