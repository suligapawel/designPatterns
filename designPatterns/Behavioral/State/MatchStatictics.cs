using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.State
{
    public class MatchStatistics
    {
        private readonly List<MatchEvent> _shoots;
        private readonly List<MatchEvent> _goals;
        private string _jugglingWinner;
        private string _penaltyWinner;

        public MatchStatistics()
        {
            _goals = new List<MatchEvent>();
            _shoots = new List<MatchEvent>();
        }

        public void AddShooter(string shooter, int minute)
        {
            Console.WriteLine($"{shooter} shoot on the goal. Goolkeeper defended shoot!");
            _shoots.Add(new MatchEvent(shooter, minute));
        }

        public void AddScorer(string scorer, int minute)
        {
            Console.WriteLine($"{scorer} shoot on the goal. GOAL on {minute}minute");
            _goals.Add(new MatchEvent(scorer, minute));
        }

        public void ShowResult()
        {
            Console.WriteLine("-- RESULT --");
            Console.WriteLine($"\nShoots on goal: {_shoots.Count}");
            WriteStatistics(_shoots);

            Console.WriteLine($"\nGoals: {_goals.Count}");
            WriteStatistics(_goals);

            Console.WriteLine($"\nJuggling winner: {_jugglingWinner}");
            Console.WriteLine($"Penalty winner: {_penaltyWinner}");
        }

        private void WriteStatistics(List<MatchEvent> statistics)
        {
            statistics.ForEach(x => Console.WriteLine($"{x.InMinute}\" {x.Footballer}"));
        }

        public void SetJugglingWinner(string value)
        {
            _jugglingWinner = value;
        }

        public void SetPenaltyWinner(string value)
        {
            _penaltyWinner = value;
        }
    }
}
