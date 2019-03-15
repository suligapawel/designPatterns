using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    class MiddleStrategy : ITeamStrategy
    {
        public void Play(Dictionary<string, Player> players)
        {
            SetPlayers(players);
            Console.WriteLine("Manager set tactic on 4-4-2. Team now play middle tactic.");
        }

        private void SetPlayers(Dictionary<string, Player> players)
        {
            players[StartingEleven.BERESZYNSKI].Position = Position.DF;
            players[StartingEleven.KRYCHOWIAK].Position = Position.MD;
            players[StartingEleven.GROSICKI].Position = Position.MD;
            players[StartingEleven.MILIK].Position = Position.AT;           
        }
    }
}
