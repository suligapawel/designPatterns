namespace designPatterns.Behavioral.ChainOfResponsibility.Abstracts
{
    public abstract class BaseFootballActionHandler
    {
        private BaseFootballActionHandler _nextAction;

        public BaseFootballActionHandler SetNext(BaseFootballActionHandler nextAction)
        {
            _nextAction = nextAction;

            return _nextAction;
        }

        public virtual void Handle()
        {
            if(_nextAction != null)
            {
                _nextAction.Handle();
            }
        }
    }
}
