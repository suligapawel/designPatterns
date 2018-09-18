using System;
using designPatterns.Creational.Prototype;
using designPatterns.Creational.Singleton;
using designPatterns.Creational.Builder;

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

            var builderClient = new BuilderClient();
            builderClient.RunClientCode();
        }
    }
}
