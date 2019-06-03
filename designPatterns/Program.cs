using System;
using designPatterns.Creational.SimpleFactory;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = SimpleFactory.GetPatternClient(DesignPattern.Flyweight);

            if (client != null)
            {
                client.RunClientCode();
            }
            else
            {
                Console.WriteLine("DesignPattern is not implemented");
            }

            Console.ReadKey();
        }
    }
}
