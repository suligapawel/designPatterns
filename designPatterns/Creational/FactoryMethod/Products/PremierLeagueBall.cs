using designPatterns.Creational.FactoryMethod.Abstracts;
using System;

namespace designPatterns.Creational.FactoryMethod.Products
{
    public class PremierLeagueBall : IBall
    {
        public void GetBallInfo()
        {
            Console.WriteLine("Premiere League Ball");
        }
    }
}
