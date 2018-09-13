using System;
using designPatterns.Creational.Prototype;
using Creational.Singleton;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonClient = new SingletonClient();
            singletonClient.RunClientCode();
          
            var prototypeClient = new PrototypeClient();
            prototypeClient.RunClientCode();
        }
    }
}
