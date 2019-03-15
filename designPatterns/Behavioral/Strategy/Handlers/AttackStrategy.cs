using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy.Handlers
{
    public class AttackStrategy : ITeamStrategy
    {
        public void Play(IEnumerable<Player> players)
        {
            SetPlayers(players);
            Console.WriteLine("Manager set tactic on 3-4-3. Team now play attack tactic.");
        }

        private void SetPlayers(IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                if (player.Name == "Bereszyński")
                    player.Position = Position.DF;

                if (player.Name == "Grosicki")
                    player.Position = Position.AT;

                if (player.Name == "Krychowiak")
                    player.Position = Position.MD;

                if (player.Name == "Milik")
                    player.Position = Position.AT;
            }
        }
    }
}
