using designPatterns.Structural.Composite.Abstracts;
using System;

namespace designPatterns.Structural.Composite.Components
{
    public class ManagerComposite : Component
    {
        public ManagerComposite(string name, bool isLeaf) : base(name, isLeaf) { }

        public override void Operation()
        {
            foreach (var trainer in _children)
            {
                Console.WriteLine($"Manager {Name} ask for training {trainer.Name}");
                trainer.Operation();
                Console.WriteLine();
            }
        }
    }
}
