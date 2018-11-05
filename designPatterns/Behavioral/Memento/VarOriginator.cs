using System;

namespace designPatterns.Behavioral.Memento
{
    public class VarOriginator
    {
        private bool _isPenalty;
        private bool _isYellowCard;
        private bool _isRedCard;

        public VarOriginator(bool isPenalty = false)
        {
            _isPenalty = isPenalty;
            Console.WriteLine($"Referee decides - penalty is... {_isPenalty}");
        }

        public void ChangePenaltyDecision(bool isPenalty)
        {
            _isPenalty = isPenalty;
            Console.WriteLine($"Referee decides - penalty is... {_isPenalty}");
        }

        public void GiveYellowCard()
        {
            if (_isYellowCard)
            {
                _isRedCard = true;
            }

            _isYellowCard = true;
            Console.WriteLine($"Referee pulls out a yellow card!");

            if (_isRedCard)
            {
                Console.WriteLine($"Referee pulls out a red card!");
            }
        }

        public VarMemento SaveRefereeDecision()
        {
            return new VarMemento(_isPenalty, _isYellowCard, _isRedCard);
        }
    }
}