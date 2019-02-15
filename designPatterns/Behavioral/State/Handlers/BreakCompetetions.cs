using designPatterns.Behavioral.State.Abstracts;
using System;
using System.Threading.Tasks;

namespace designPatterns.Behavioral.State.Handlers
{
    public class BreakCompetetions : IMatchState
    {
        public async Task Run(MatchStatistics dataContext)
        {
            var penaltyKicks = PenaltyKicks(dataContext);
            var juggling = Juggling(dataContext);

            await Task.WhenAll(penaltyKicks, juggling);
        }

        public async Task PenaltyKicks(MatchStatistics dataContext)
        {
            var fans = new[] { "Paul", "Jack", "Brian" };
            dataContext.SetPenaltyWinner(await RunCompetetion(fans, 5));
        }

        public async Task Juggling(MatchStatistics dataContext)
        {
            var fans = new[] { "Piter", "Robert", "Stephen" };
            dataContext.SetJugglingWinner(await RunCompetetion(fans, 100));
        }

        private async Task<string> RunCompetetion(string[] fans, int maxValue)
        {
            var random = new Random();
            int fansCount = fans.Length;
            int theBestResult = 0;
            string winner = string.Empty;

            await Task.Run(() =>
            {
                Console.WriteLine("-- START NEW COMPETETION --");
                while (fansCount > 0)
                {
                    var fan = fans[fansCount - 1];
                    int result = random.Next(0, maxValue);
                    Console.WriteLine($"{fan} gain {result} points.");

                    if (result > theBestResult)
                    {
                        theBestResult = result;
                        winner = fans[fansCount - 1];
                        Console.WriteLine($"{fan} puts on the lead!");
                    }
                    fansCount--;
                }
            });

            return winner;
        }
    }
}
