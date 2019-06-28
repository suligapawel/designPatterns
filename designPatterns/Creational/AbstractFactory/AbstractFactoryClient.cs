using designPatterns.Creational.AbstractFactory.ConcreteFactories;
using System;

namespace designPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START ABSTRACT FACTORY *****");

            var matchOutfit = new Outfit(new MatchOutfit());
            var replica = new Outfit(new ReplicaOutfit());

            Console.WriteLine($"Strój meczowy zawiera:");
            Console.WriteLine(matchOutfit.GetOutfitInfo());
            Console.WriteLine($"KOSZT: {matchOutfit.CalculateCoast()}");
            Console.WriteLine();

            Console.WriteLine($"Replika stroju zawiera:");
            Console.WriteLine(replica.GetOutfitInfo());
            Console.WriteLine($"KOSZT: {replica.CalculateCoast()}");

            Console.WriteLine("***** END ABSTRACT FACTORY *****");
        }
    }
}
