namespace designPatterns.Behavioral.Visitor.Abstracts
{
    public abstract class BaseFootballer
    {
        protected readonly string _name;

        public BaseFootballer(string name)
        {
            _name = name;
        }

        public abstract string IntroduceYourself();
        public abstract string Accept(IVisitor visitor);
    }
}
