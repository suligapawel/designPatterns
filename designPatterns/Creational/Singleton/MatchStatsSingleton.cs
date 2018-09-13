using System;

namespace Creational.Singleton
{
    public class MatchStatsSingleton
    {
        private static MatchStatsSingleton _instance;

        private int _yellowCardsInFirstHalfCount;
        private int _redCardsInFirstHalfCount;
        private int _yellowCardsInSecontHalfCount;
        private int _redCardsInSecondHalfCount;

        private MatchStatsSingleton() { }

        public static MatchStatsSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MatchStatsSingleton();
            }

            return _instance;
        }

        public void ShowYellowCard(HalfEnum half)
        {
            if (half == HalfEnum.First)
            {
                _yellowCardsInFirstHalfCount++;
            }
            else
            {
                _yellowCardsInSecontHalfCount++;
            }

            Console.WriteLine("Referre pulls out a yellow card!");
        }

        public void ShowRedCard(HalfEnum half)
        {
            if (half == HalfEnum.First)
            {
                _redCardsInFirstHalfCount++;
            }
            else
            {
                _redCardsInSecondHalfCount++;
            }

            Console.WriteLine("What a foul. Referee pulls out a red card.");
        }

        public void GetFirstHalfStats()
        {
            Console.WriteLine($"FIRST HALF STATS: yellow cards: {_yellowCardsInFirstHalfCount}, Red cards: {_redCardsInFirstHalfCount}");
        }

        public void GetSecondHalfStats()
        {
            Console.WriteLine($"SECOND HALF STATS: yellow cards: {_yellowCardsInSecontHalfCount}, Red cards: {_redCardsInSecondHalfCount}");
        }

        public void GetMatchStats()
        {
            int yellowCards = _yellowCardsInFirstHalfCount + _yellowCardsInSecontHalfCount;
            int redCards = _redCardsInFirstHalfCount + _redCardsInSecondHalfCount;

            Console.WriteLine($"MATCH STATS: yellow cards: {yellowCards}, Red cards: {redCards}");
        }
    }
}