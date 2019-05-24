using designPatterns.Structural.Flyweight.Abstracts;
using System.Collections.Generic;

namespace designPatterns.Structural.Flyweight
{
    public class FakeDb
    {
        private const string LIVERPOOL = "Liverpool";
        private const string LEGIA = "Legia";
        private static int count = 1;

        public static readonly Dictionary<int, IFlyweightFan> Fans = new Dictionary<int, IFlyweightFan>
        {
            { count, new Fan(count++, "John", "Balboa", LIVERPOOL) },
            { count, new Fan(count++, "Jack", "Gordon", LIVERPOOL) },
            { count, new Fan(count++, "Brian", "Sanchez", LIVERPOOL) },
            { count, new Fan(count++, "Nick", "Rambo", LIVERPOOL) },
            { count, new Fan(count++, "Jan", "Kowalski", LEGIA) },
            { count, new Fan(count++, "Cezary", "Nowak", LEGIA) },
            { count, new Fan(count++, "Piotr", "Zieleńczak", LEGIA) },
            { count, new Fan(count++, "Jeż", "Jerzy", LEGIA) },
        };

    }
}
