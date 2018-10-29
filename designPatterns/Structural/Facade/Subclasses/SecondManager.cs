using System;

namespace designPatterns.Structural.Facade.Subclasses
{
    public class SecondManager
    {
        public void ReportChangeToTechnicalReferee(Footballer takeOffFootballer, Footballer enterFootballer)
        {
            Console.WriteLine($"Take off player with number {takeOffFootballer.Number}.");
            Console.WriteLine($"Enter player with number {enterFootballer.Number}.");
        }
    }
}