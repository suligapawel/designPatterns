using designPatterns.Behavioral.Visitor.Abstracts;
using designPatterns.Behavioral.Visitor.Elements;
using System.Globalization;

namespace designPatterns.Behavioral.Visitor
{
    public partial class Visitor : IVisitor
    {
        public string PrepareContract(Amator amator)
        {
            return $"Footballer type: {amator.GetType().Name}, Salary: {10.ToString("C", CultureInfo.GetCultureInfo("pl-PL"))}";
        }
    }
}
