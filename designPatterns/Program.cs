using System;
using designPatterns.Creational.Prototype;
using Creational.Singleton;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonClient = new MatchClient();
            SingletonClient.RunClientCode();
          
            var prototypeClient = new FootballClient();
            prototypeClient.RunClientCode();
        }
    }
}
