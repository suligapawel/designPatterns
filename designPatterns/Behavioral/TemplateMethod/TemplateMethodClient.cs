using designPatterns.Behavioral.TemplateMethod.Abstracts;
using designPatterns.Behavioral.TemplateMethod.ConcreteClasses;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.TemplateMethod
{
    public class TemplateMethodClient : IClient
    {
        private readonly List<BasePenaltyShooter> _penaltyShooters;
        private int _firstTeamScored = 0;
        private int _secondTeamScored = 0;

        public TemplateMethodClient()
        {
            _penaltyShooters = new List<BasePenaltyShooter>
            {
                new ApatheticPlayer(),
                new ApatheticPlayer(),
                new EmotionalPlayer(),
                new ApatheticPlayer(),
                new EmotionalPlayer(),
                new EmotionalPlayer(),
                new ApatheticPlayer(),
                new EmotionalPlayer(),
                new EmotionalPlayer(),
                new ApatheticPlayer()
            };
        }

        public void RunClientCode()
        {
            PlayPenaltyContest();
            Console.WriteLine($"WYNIK KOŃCOWY: {_firstTeamScored} : {_secondTeamScored}");

        }

        private void PlayPenaltyContest()
        {
            int goal = 0;

            for (int i = 0; i < _penaltyShooters.Count; i++)
            {
                goal = _penaltyShooters[i].ShootPenalty() ? 1 : 0;

                if (i % 2 == 0)
                {
                    _firstTeamScored += goal;
                }
                else
                {
                    _secondTeamScored += goal;
                }
                Console.WriteLine(string.Empty);
            }
        }
    }
}
