using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy
{
    public class ContextStrategy
    {
        private readonly Dictionary<string, Player> _players;
        private ITeamStrategy _strategy;

        public ContextStrategy()
        {
            _players = StartingEleven.Players;
        }

        public void SetStrategy(ITeamStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PlayWithSetStrategy()
        {
            _strategy.Play(_players);
            WriteTactic();
        }

        private void WriteTactic()
        {
            List<string> defenders = new List<string>();
            List<string> midfielders = new List<string>();
            List<string> attackers = new List<string>();

            foreach (var player in _players)
            {
                switch (player.Value.Position)
                {
                    case Position.DF:
                        defenders.Add(player.Key);
                        break;
                    case Position.MD:
                        midfielders.Add(player.Key);
                        break;
                    case Position.AT:
                        attackers.Add(player.Key);
                        break;
                }
            }

            Console.WriteLine($"OBROŃCY: {string.Join(", ", defenders)}");
            Console.WriteLine($"POMOCNICY: {string.Join(", ", midfielders)}");
            Console.WriteLine($"ATAKUJĄCY: {string.Join(", ", attackers)}");
            Console.WriteLine(string.Empty);
        }
    }
}
