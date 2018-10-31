namespace designPatterns.Behavioral.Observer.Abstracts
{
    public interface IYoungFootballerSubject
    {
        void AddObserver(ISubscriber scout);
        void NotifyObservers();
        IYoungFootballerSubject PlayGoodMatch();
        IYoungFootballerSubject PlayBadMatch();
    }
}