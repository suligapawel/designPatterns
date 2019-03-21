using designPatterns.Creational.AbstractFactory.ConcreteFactories;
using System;

namespace designPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryClient : IClient
    {
        public void RunClientCode()
        {
            var matchOutfit = new Outfit(new MatchOutfit());
            var replica = new Outfit(new ReplicaOutfit());

            Console.WriteLine($"Strój meczowy zawiera:");
            Console.WriteLine(matchOutfit.GetOutfitInfo());
            Console.WriteLine($"KOSZT: {matchOutfit.CalculateCoast()}");
            Console.WriteLine();

            Console.WriteLine($"Replika stroju zawiera:");
            Console.WriteLine(replica.GetOutfitInfo());
            Console.WriteLine($"KOSZT: {replica.CalculateCoast()}");
        }
    }
}
