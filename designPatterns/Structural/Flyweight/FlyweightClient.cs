using designPatterns.Structural.Flyweight.Abstracts;
using System;

namespace designPatterns.Structural.Flyweight
{
    public class FlyweightClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START FLYWEIGHT *****");
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            IFlyweightFan fan = flyweightFactory.GetFan(1);
            Console.WriteLine(fan.GetInfo());

            fan = flyweightFactory.GetFan(6);
            Console.WriteLine(fan.GetInfo());

            fan = flyweightFactory.GetFan(9, "Ferdynand", "Mąka", "Real");
            Console.WriteLine(fan.GetInfo());

            fan = flyweightFactory.GetFan(9);
            Console.WriteLine(fan.GetInfo());

            Console.WriteLine("***** END FLYWEIGHT *****");
        }
    }
}
