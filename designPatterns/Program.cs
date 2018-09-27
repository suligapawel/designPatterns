using System;
using designPatterns.Creational.Prototype;
using designPatterns.Creational.Singleton;
using designPatterns.Creational.Builder;
using designPatterns.Structural.Adapter;
using designPatterns.Behavioral.Command;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("~~~~~ START CREATIONAL DESIGN PATTERNS ~~~~~");

            // var singletonClient = new SingletonClient();
            // singletonClient.RunClientCode();

            // var prototypeClient = new PrototypeClient();
            // prototypeClient.RunClientCode();

            // var builderClient = new BuilderClient();
            // builderClient.RunClientCode();
            // Console.WriteLine("~~~~~ END CREATIONAL DESIGN PATTERNS ~~~~~");

            Console.WriteLine("~~~~~ START STRUCTURAL DESIGN PATTERNS ~~~~~");

            var adapterClient = new AdapterClient();
            adapterClient.RunClientCode();

            Console.WriteLine("~~~~~ END STRUCTURAL DESIGN PATTERNS ~~~~~");

            // Console.WriteLine("~~~~~ START BEHAVIORAL DESIGN PATTERNS ~~~~~");

            // var commandClient = new CommandClient();
            // commandClient.RunClientCode();

            // Console.WriteLine("~~~~~ END BEHAVIORAL DESIGN PATTERNS ~~~~~");
        }
    }
}
