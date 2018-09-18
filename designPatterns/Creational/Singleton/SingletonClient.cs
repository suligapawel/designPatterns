using System;

namespace designPatterns.Creational.Singleton
{
    public class SingletonClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START SINGLETON *****");
            MatchStatsSingleton firstHalf = MatchStatsSingleton.GetInstance();

            for (int i = 0; i < 4; i++)
            {
                firstHalf.ShowYellowCard(HalfEnum.First);
            }

            firstHalf.ShowRedCard(HalfEnum.First);

            firstHalf.GetFirstHalfStats();
            firstHalf.GetSecondHalfStats();

            Console.WriteLine("--- END FIRST HALF ---");

            MatchStatsSingleton secondHalf = MatchStatsSingleton.GetInstance();

            Console.WriteLine("--- START SECOND HALF ---");

            secondHalf.GetFirstHalfStats();

            secondHalf.ShowYellowCard(HalfEnum.Second);
            secondHalf.ShowRedCard(HalfEnum.Second);

            secondHalf.GetSecondHalfStats();
            secondHalf.GetMatchStats();

            Console.WriteLine("***** END SINGLETON *****");
            Console.WriteLine();
        }
    }
}