using designPatterns.Structural.Composite.Abstracts;
using System;

namespace designPatterns.Structural.Composite.Components
{
    public class TrainerComposite : Component
    {
        public TrainerComposite(string name, bool isLeaf) : base(name, isLeaf) { } 

        public override void Operation()
        {
            Console.WriteLine($"{Name} start training.");

            foreach (var footballer in _children)
            {
                footballer.Operation();
            }
        }
    }
}
