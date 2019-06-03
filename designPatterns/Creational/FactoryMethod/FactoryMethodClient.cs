using designPatterns.Creational.FactoryMethod.Abstracts;
using designPatterns.Creational.FactoryMethod.Factories;
using System;

namespace designPatterns.Creational.FactoryMethod
{
    public class FactoryMethodClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START FACTORY METHOD *****");

            BaseCreator creator;

            creator = new ChampionsLeagueCreator();
            IBall ball = creator.CreateBall();
            ball.GetBallInfo();

            creator = new PremierLeagueCreator();
            ball = creator.CreateBall();
            ball.GetBallInfo();

            creator = new FaCupCreator();
            ball = creator.CreateBall();
            ball.GetBallInfo();

            Console.WriteLine("***** END FACADE *****");
        }
    }
}
