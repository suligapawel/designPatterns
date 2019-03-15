using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    class MiddleStrategy : ITeamStrategy
    {
        public void Play(IEnumerable<Player> players)
        {
            SetPlayers(players);
            Console.WriteLine("Manager set tactic on 4-4-2. Team now play middle tactic.");
        }

        private void SetPlayers(IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                if (player.Name == "Bereszyński")
                    player.Position = Position.DF;

                if (player.Name == "Krychowiak")
                    player.Position = Position.MD;

                if (player.Name == "Grosicki")
                    player.Position = Position.MD;

                if (player.Name == "Milik")
                    player.Position = Position.AT;
            }
        }
    }
}
