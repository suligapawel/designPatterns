using System;
using Creational.Singleton;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var SingletonClient = new MatchClient();
            SingletonClient.RunClientCode();
        }
    }
}
