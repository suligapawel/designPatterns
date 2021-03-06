﻿using designPatterns.Behavioral.Visitor.Abstracts;

namespace designPatterns.Behavioral.Visitor.Elements
{
    public class Amator : BaseFootballer
    {
        public Amator(string name) : base(name) { }

        public override string IntroduceYourself() => $"Hi! I am {_name} - amator footballer";

        public override string Accept(IVisitor visitor)
        {
            return visitor.PrepareContract(this);
        }
    }
}
