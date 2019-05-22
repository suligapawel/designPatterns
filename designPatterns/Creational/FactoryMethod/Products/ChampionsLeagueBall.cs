using designPatterns.Creational.FactoryMethod.Abstracts;
using System;

namespace designPatterns.Creational.FactoryMethod.Products
{
    public class ChampionsLeagueBall : IBall
    {
        public void GetBallInfo()
        {
            Console.WriteLine("Champions League Ball");
        }
    }
}
