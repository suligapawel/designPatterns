using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    public class DefenseStrategy : ITeamStrategy
    {
        public void Play(IEnumerable<Player> players)
        {
            SetPlayers(players);
            Console.WriteLine("Manager set tactic on 5-4-1. Team now play defense tactic.");
        }

        private void SetPlayers(IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                if (player.Name == "Bereszyński")
                    player.Position = Position.DF;

                if (player.Name == "Krychowiak")
                    player.Position = Position.DF;

                if (player.Name == "Grosicki")
                    player.Position = Position.MD;

                if (player.Name == "Milik")
                    player.Position = Position.MD;
            }
        }
    }
}
