using designPatterns.Behavioral.Visitor.Elements;

namespace designPatterns.Behavioral.Visitor.Abstracts
{
    public interface IVisitor
    {
        string PrepareContract(Star star);
        string PrepareContract(Amator amator);
    }
}
