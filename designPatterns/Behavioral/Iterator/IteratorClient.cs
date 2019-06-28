using designPatterns.Behavioral.Iterator.Abstracts;
using System;
using System.Collections.Generic;

namespace designPatterns.Behavioral.Iterator
{
    public class IteratorClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START ITERATOR *****");

            var footballers = new List<string> {
                "Gerard",
                "Zidane",
                "Ronaldo",
                "Pele",
                "Maradona",
                "Boniek",
                "Buffon",
                "Casillas"
            };

            IAggregate footballerInTraining = new FootballersInTrainingCollection(footballers);

            Console.WriteLine("FIRST TEAM");
            foreach (var footballer in footballerInTraining)
            {
                Console.WriteLine(footballer);
            }

            footballerInTraining.FirstTeamChoice();

            Console.WriteLine("SECOND TEAM");
            foreach (var footballer in footballerInTraining)
            {
                Console.WriteLine(footballer);
            }

            Console.WriteLine("***** END ITERATOR *****");
        }
    }
}
