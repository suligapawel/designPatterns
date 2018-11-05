using System;

namespace designPatterns.Behavioral.Memento
{
    public class MementoClient : IClient
    {
        private readonly VarCaretaker _varCaretaker;

        public MementoClient()
        {
            _varCaretaker = new VarCaretaker();
        }

        public void RunClientCode()
        {
            Console.WriteLine("***** START MEMENTO *****");

            var originator = new VarOriginator();

            _varCaretaker.AddMemento(originator.SaveRefereeDecision());
            _varCaretaker.ShowAllMementos();

            originator.ChangePenaltyDecision(true);
            originator.GiveYellowCard();

            _varCaretaker.AddMemento(originator.SaveRefereeDecision());
            _varCaretaker.ShowAllMementos();

            originator.GiveYellowCard();

            _varCaretaker.AddMemento(originator.SaveRefereeDecision());
            _varCaretaker.ShowAllMementos();

            _varCaretaker.UndoLastDecision();
            _varCaretaker.ShowAllMementos();

            Console.WriteLine("***** END MEMENTO *****");
        }
    }
}