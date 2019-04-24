using designPatterns.Structural.Proxy.Abstracts;
using System;

namespace designPatterns.Structural.Proxy
{
    public class FootballerSalary : ISalary
    {
        private const decimal SALARY = 10_000m;

        private readonly bool _scoredGoal;
        private readonly bool _hasCards;

        private decimal _sumSalary;

        public FootballerSalary(bool scoredGoal, bool hasCards)
        {
            _scoredGoal = scoredGoal;
            _hasCards = hasCards;

            _sumSalary = SALARY;
        }

        public decimal WithdrawPayment()
        {
            AddBonusForGoals();
            SubstractSalaryForCards();

            return _sumSalary;
        }

        private void AddBonusForGoals()
        {
            decimal bonusPercent = 0.1m;

            if (_scoredGoal)
            {
                decimal bonus = _sumSalary * bonusPercent;

                _sumSalary += bonus;
                Console.WriteLine($"Club added bonus for goals - {bonus:C}");
            }
        }

        private void SubstractSalaryForCards()
        {
            decimal penaltyPercent = 0.3m;

            if (_hasCards)
            {
                decimal penalty = _sumSalary * penaltyPercent;

                _sumSalary -= _sumSalary * penaltyPercent;
                Console.WriteLine($"Club substract penalty for cards - {penalty:C}");
            }
        }
    }
}
