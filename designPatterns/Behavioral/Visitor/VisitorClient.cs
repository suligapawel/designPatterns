using designPatterns.Behavioral.Visitor.Abstracts;
using designPatterns.Behavioral.Visitor.Elements;
using System;
using System.Globalization;

namespace designPatterns.Behavioral.Visitor
{
    public class VisitorClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START VISITOR *****");

            var visitor = new Visitor();
            BaseFootballer footballer = new Amator("Fred Blogs");
            Console.WriteLine(footballer.IntroduceYourself());

            // Bad Example
            BadExample(footballer);

            // Visitor example
            var salary = footballer.Accept(visitor);
            Console.WriteLine(salary);


            footballer = new Star("C. Ronaldo");
            Console.WriteLine(footballer.IntroduceYourself());
            salary = footballer.Accept(visitor);
            Console.WriteLine(salary);

            Console.WriteLine("***** END VISITOR *****");
        }

        private void BadExample(BaseFootballer footballer)
        {
            string salary = string.Empty;

            if (footballer is Amator)
            {
                salary = $"Footballer type: {footballer.GetType().Name}, Salary: {10.ToString("C", CultureInfo.GetCultureInfo("pl-PL"))}";
            }
            if (footballer is Star)
            {
                salary = $"Footballer type: {footballer.GetType().Name} Salary: {1_000_000.ToString("C", CultureInfo.GetCultureInfo("pl-PL"))}";
            }

            Console.WriteLine(salary);

        }
    }
}
