namespace designPatterns.Behavioral.State
{
    public class MatchEvent
    {
        public string Footballer { get; }
        public int InMinute { get; }

        public MatchEvent(string footballer, int inMinute)
        {
            Footballer = footballer;
            InMinute = inMinute;
        }
    }
}
