using System;
using designPatterns.Behavioral.Command;
using designPatterns.Behavioral.Observer;
using designPatterns.Behavioral.Memento;
using designPatterns.Behavioral.State;
using designPatterns.Creational.Prototype;
using designPatterns.Creational.Singleton;
using designPatterns.Creational.Builder;
using designPatterns.Structural.Adapter;
using designPatterns.Structural.Composite;
using designPatterns.Structural.Facade;
using designPatterns.Behavioral.Strategy;
using designPatterns.Behavioral.TemplateMethod;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client;
            //Console.WriteLine("~~~~~ START CREATIONAL DESIGN PATTERNS ~~~~~");

            //client = new SingletonClient();
            //client.RunClientCode();

            //client = new PrototypeClient();
            //client.RunClientCode();

            //client = new BuilderClient();
            //client.RunClientCode();
            //Console.WriteLine("~~~~~ END CREATIONAL DESIGN PATTERNS ~~~~~");

            //Console.WriteLine("~~~~~ START STRUCTURAL DESIGN PATTERNS ~~~~~");

            //client = new AdapterClient();
            //client.RunClientCode();

            //client = new FacadeClient();
            //client.RunClientCode();

            //client = new CompositeClient();
            //client.RunClientCode();

            //Console.WriteLine("~~~~~ END STRUCTURAL DESIGN PATTERNS ~~~~~");

            //Console.WriteLine("~~~~~ START BEHAVIORAL DESIGN PATTERNS ~~~~~");

            //client = new CommandClient();
            //client.RunClientCode();

            //client = new ObserverClient();
            //client.RunClientCode();

            //client = new MementoClient();
            //client.RunClientCode();

            //client = new StateClient();
            //client.RunClientCode();

            client = new StrategyClient();
            client.RunClientCode();

            //client = new TemplateMethodClient();
            //client.RunClientCode();

            //Console.WriteLine("~~~~~ END BEHAVIORAL DESIGN PATTERNS ~~~~~");
            Console.ReadKey();
        }
    }
}
