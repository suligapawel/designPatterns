using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    public class DefenseStrategy : ITeamStrategy
    {
        public void Play(Dictionary<string, Player> players)
        {
            SetPlayers(players);
            Console.WriteLine("Manager set tactic on 5-4-1. Team now play defense tactic.");
        }

        private void SetPlayers(Dictionary<string, Player> players)
        {
            players[StartingEleven.BERESZYNSKI].Position = Position.DF;
            players[StartingEleven.KRYCHOWIAK].Position = Position.DF;
            players[StartingEleven.GROSICKI].Position = Position.MD;
            players[StartingEleven.MILIK].Position = Position.MD;           
        }
    }
}
