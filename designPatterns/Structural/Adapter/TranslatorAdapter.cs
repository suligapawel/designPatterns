using designPatterns.Structural.Adapter.Abstracts;
using designPatterns.Structural.Adapter.Handlers;

namespace designPatterns.Structural.Adapter
{
    public class TranslatorAdapter : IAfterMatchConference
    {
        private readonly GermanFootballer _germanFootballer;
        public TranslatorAdapter(GermanFootballer germanFootballer)
        {
            _germanFootballer = germanFootballer;
        }

        public void GiveInterviewInPolish()
        {
            _germanFootballer.GiveInterviewInGerman();
        }
    }
}