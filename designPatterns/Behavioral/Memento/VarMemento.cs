using System;

namespace designPatterns.Behavioral.Memento
{
    public class VarMemento
    {
        public bool IsPenalty { get; private set; }
        public bool IsYellowCard { get; private set; }
        public bool IsRedCard { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public VarMemento(bool isPenalty, bool isYellowCard, bool isRedCard)
        {
            IsPenalty = isPenalty;
            IsYellowCard = isYellowCard;
            IsRedCard = isRedCard;
            CreatedDate = DateTime.Now;
        }
    }
}