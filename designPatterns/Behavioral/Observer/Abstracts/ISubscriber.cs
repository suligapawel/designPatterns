namespace designPatterns.Behavioral.Observer.Abstracts
{
    public interface ISubscriber
    {
        string Team { get; }
        string Type { get; }
        bool SendMessage(YoungFootballerSubject subject);
    }
}