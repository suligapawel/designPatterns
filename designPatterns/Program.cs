using System;
using designPatterns.Creational.Prototype;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballClient prototypeClient = new FootballClient();
            prototypeClient.RunClientCode();
        }
    }
}
