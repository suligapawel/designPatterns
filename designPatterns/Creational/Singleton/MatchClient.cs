using System;

namespace Creational.Singleton
{
    public class MatchClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("--- START MATCH ---");
            MatchStatsSingleton firstHalf = MatchStatsSingleton.GetInstance();

            firstHalf.ShowYellowCard(HalfEnum.First);
            firstHalf.ShowYellowCard(HalfEnum.First);
            firstHalf.ShowYellowCard(HalfEnum.First);
            firstHalf.ShowRedCard(HalfEnum.First);

            firstHalf.GetFirstHalfStats();
            firstHalf.GetSecondHalfStats();

            Console.WriteLine("--- END FIRST HALF---");

            MatchStatsSingleton secondHalf = MatchStatsSingleton.GetInstance();

            Console.WriteLine("--- START SECOND HALF ---");

            secondHalf.GetFirstHalfStats();

            secondHalf.ShowYellowCard(HalfEnum.Second);
            secondHalf.ShowRedCard(HalfEnum.Second);

            secondHalf.GetSecondHalfStats();
            secondHalf.GetMatchStats();

            Console.WriteLine("--- END MATCH ---");
        }
    }
}