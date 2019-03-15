using System.Collections.Generic;

namespace designPatterns.Behavioral.Strategy
{
    public class StartingEleven
    {
        public const string SZCZESNY = "Szczęsny";
        public const string JEDRZEJCZYK = "Jędrzejczyk";
        public const string GLIK = "Glik";
        public const string BEDNAREK = "Bednarek";
        public const string BERESZYNSKI = "Bereszyński";
        public const string KRYCHOWIAK = "Krychowiak";
        public const string GROSICKI = "Grosicki";
        public const string LINETTY = "Linetty";
        public const string ZIELINSKI = "Zieliński";
        public const string MILIK = "Milik";
        public const string LEWANDOWSKI = "Lewandowski";

        public static Dictionary<string, Player> Players { get; } = new Dictionary<string, Player>
        {
            {SZCZESNY, new Player(SZCZESNY, Position.GK) },
            {JEDRZEJCZYK, new Player(JEDRZEJCZYK, Position.DF) },
            {GLIK, new Player(GLIK, Position.DF) },
            {BEDNAREK, new Player(BEDNAREK, Position.DF) },
            {BERESZYNSKI, new Player(BERESZYNSKI, Position.DF) },
            {KRYCHOWIAK, new Player(KRYCHOWIAK, Position.MD) },
            {GROSICKI, new Player(GROSICKI, Position.MD) },
            {LINETTY, new Player(LINETTY, Position.MD) },
            {ZIELINSKI, new Player(ZIELINSKI, Position.MD) },
            {MILIK, new Player(MILIK, Position.AT) },
            {LEWANDOWSKI, new Player(LEWANDOWSKI, Position.AT) }
        };
    }
}
