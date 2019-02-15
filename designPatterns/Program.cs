using System;
using designPatterns.Creational.Prototype;
using designPatterns.Creational.Singleton;
using designPatterns.Creational.Builder;
using designPatterns.Structural.Adapter;
using designPatterns.Behavioral.Command;
using designPatterns.Structural.Facade;
using designPatterns.Behavioral.Observer;
using designPatterns.Behavioral.Memento;
using designPatterns.Structural.Composite;
using designPatterns.Behavioral.State;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("~~~~~ START CREATIONAL DESIGN PATTERNS ~~~~~");

            // IClient singletonClient = new SingletonClient();
            // singletonClient.RunClientCode();

            // IClient prototypeClient = new PrototypeClient();
            // prototypeClient.RunClientCode();

            // IClient builderClient = new BuilderClient();
            // builderClient.RunClientCode();
            // Console.WriteLine("~~~~~ END CREATIONAL DESIGN PATTERNS ~~~~~");

            // Console.WriteLine("~~~~~ START STRUCTURAL DESIGN PATTERNS ~~~~~");

            // IClient adapterClient = new AdapterClient();
            // adapterClient.RunClientCode();

            //IClient facadeClient = new FacadeClient();
            //facadeClient.RunClientCode();

            //IClient compositeClient = new CompositeClient();
            //compositeClient.RunClientCode();

            // Console.WriteLine("~~~~~ END STRUCTURAL DESIGN PATTERNS ~~~~~");

            // Console.WriteLine("~~~~~ START BEHAVIORAL DESIGN PATTERNS ~~~~~");

            // IClient commandClient = new CommandClient();
            // commandClient.RunClientCode();

            //IClient observerClient = new ObserverClient();
            //observerClient.RunClientCode();

            //IClient mementoClient = new MementoClient();
            //mementoClient.RunClientCode();

            IClient stateClient = new StateClient();
            stateClient.RunClientCode();

            // Console.WriteLine("~~~~~ END BEHAVIORAL DESIGN PATTERNS ~~~~~");
            Console.ReadKey();
        }
    }
}
