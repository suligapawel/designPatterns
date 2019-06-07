using designPatterns.Behavioral.Visitor.Abstracts;
using designPatterns.Behavioral.Visitor.Elements;
using System.Globalization;

namespace designPatterns.Behavioral.Visitor
{
    public partial class Visitor : IVisitor
    {
        public string PrepareContract(Star star)
        {
            return $"Footballer type: {star.GetType().Name}, Salary: {1_000_000.ToString("C", CultureInfo.GetCultureInfo("pl-PL"))}";
        }
    }
}
