namespace designPatterns.Behavioral.Strategy
{
    public class Player
    {
        public string Name { get; private set; }
        public Position Position { get; set; }

        public Player(string name, Position position)
        {
            Name = name;
            Position = position;

        }
    }

    public enum Position
    {
        GK,
        DF,
        MD,
        AT
    }
}
