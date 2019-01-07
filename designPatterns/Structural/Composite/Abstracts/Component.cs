using System.Collections.Generic;

namespace designPatterns.Structural.Composite.Abstracts
{
    public abstract class Component
    {
        protected List<Component> _children;
        public string Name { get; }

        public Component(string name, bool isLeaf)
        {
            Name = name;

            if (!isLeaf)
                _children = new List<Component>();
        }

        public void AddChild(Component child)
        {
            if (_children != null)
                _children.Add(child);
        }

        public abstract void Operation();
    }
}
