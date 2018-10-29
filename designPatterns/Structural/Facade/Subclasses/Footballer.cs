namespace designPatterns.Structural.Facade.Subclasses
{
    public class Footballer
    {
        public int Number { get; private set; }

        public Footballer(int number)
        {
            Number = number;
        }
    }
}