using designPatterns.Structural.Composite.Abstracts;
using System;

namespace designPatterns.Structural.Composite.Components
{
    public class TrainerComposite : Component
    {
        public TrainerComposite(string name, bool isLeaf) : base(name, isLeaf) { } 

        public override void Operation()
        {
            foreach (var footballer in _children)
            {
                Console.WriteLine($"Trainer {Name} trains the {footballer.Name}");
                footballer.Operation();
            }
        }
    }
}
