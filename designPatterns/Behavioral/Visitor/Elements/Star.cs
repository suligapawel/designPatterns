using designPatterns.Behavioral.Visitor.Abstracts;

namespace designPatterns.Behavioral.Visitor.Elements
{
    public class Star : BaseFootballer
    {
        public Star(string name) : base(name) { }

        public override string IntroduceYourself() => $"Hi! I am {_name} - professional footballer";
        public override string Accept(IVisitor visitor)
        {
           return visitor.PrepareContract(this);
        }
    }
}
