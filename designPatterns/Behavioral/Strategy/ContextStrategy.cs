using designPatterns.Behavioral.Strategy.Abstract;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy
{
    public class ContextStrategy
    {
        private ITeamStrategy _strategy;
        private List<Player> _players = new List<Player>
        {
            new Player("Sczęsny", Position.GK),
            new Player("Jędrzejczyk", Position.DF), new Player("Glik", Position.DF), new Player("Bednarek", Position.DF), new Player("Bereszyński", Position.DF),
            new Player("Krychowiak", Position.MD), new Player("Grosicki", Position.MD), new Player("Linetty", Position.MD), new Player("Zieliński", Position.MD),
            new Player("Lewandowski", Position.AT), new Player("Milik", Position.AT)
         };

        public void SetStrategy(ITeamStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PlayWithSetStrategy()
        {
            _strategy.Play(_players);
            WriteTactic();
            Console.WriteLine(string.Empty);
        }

        private void WriteTactic()
        {
            List<string> defenders = new List<string>();
            List<string> midfielders = new List<string>();
            List<string> attackers = new List<string>();

            _players.ForEach(x =>
            {
                switch (x.Position)
                {
                    case Position.DF:
                        defenders.Add(x.Name);
                        break;
                    case Position.MD:
                        midfielders.Add(x.Name);
                        break;
                    case Position.AT:
                        attackers.Add(x.Name);
                        break;
                }
            });

            Console.WriteLine($"OBROŃCY: {string.Join(',', defenders)}");
            Console.WriteLine($"POMOCNICY: {string.Join(',', midfielders)}");
            Console.WriteLine($"ATAKUJĄCY: {string.Join(',', attackers)}");
        }
    }
}
