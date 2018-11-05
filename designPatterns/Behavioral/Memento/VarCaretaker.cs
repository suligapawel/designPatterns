using System;
using System.Collections.Generic;
using System.Linq;

namespace designPatterns.Behavioral.Memento
{
    public class VarCaretaker
    {
        private List<VarMemento> _mementos = new List<VarMemento>();

        public void AddMemento(VarMemento memento)
        {
            _mementos.Add(memento);
        }

        public void UndoLastDecision()
        {
            if (!_mementos.Any())
            {
                return;
            }

            _mementos.Remove(_mementos.Last());
            Console.WriteLine("Remove last referee decision");
        }

        public void ShowAllMementos()
        {
            _mementos.ForEach(m =>
            {
                Console.WriteLine($"Is penalty? {m.IsPenalty}, is yellow card? {m.IsYellowCard}"
                 + $", is red card? {m.IsRedCard}, time: {m.CreatedDate.Millisecond}");
            });
            Console.WriteLine();
        }
    }
}