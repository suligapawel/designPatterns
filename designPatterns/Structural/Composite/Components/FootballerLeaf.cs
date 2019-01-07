using designPatterns.Structural.Composite.Abstracts;
using System;

namespace designPatterns.Structural.Composite.Components
{
    public class FootballerLeaf : Component
    {
        public FootballerLeaf(string name, bool isLeaf) : base(name, isLeaf) { }

        public override void Operation()
        {
            Console.WriteLine($"Footballer {Name} is training");
        }
    }
}
