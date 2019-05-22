using designPatterns.Creational.FactoryMethod.Abstracts;
using System;

namespace designPatterns.Creational.FactoryMethod.Products
{
    public class FaCupBall : IBall
    {
        public void GetBallInfo()
        {
            Console.WriteLine("FA CUP Ball");
        }
    }
}
