using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    public class AttackStrategy : ITeamStrategy
    {
        public void Play(Dictionary<string, Player> players)
        {
            SetPlayers(players);
            Console.WriteLine("Manager set tactic on 3-4-3. Team now play attack tactic.");
        }

        private void SetPlayers(Dictionary<string, Player> players)
        {
            players[StartingEleven.BERESZYNSKI].Position = Position.MD;
            players[StartingEleven.KRYCHOWIAK].Position = Position.MD;
            players[StartingEleven.GROSICKI].Position = Position.AT;
            players[StartingEleven.MILIK].Position = Position.AT;           
        }
    }
}
