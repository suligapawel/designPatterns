using System;
using designPatterns.Behavioral.Command;
using designPatterns.Behavioral.Command.Handlers;

namespace designPatterns.Behavioral.Command
{
    public class CommandClient : IClient
    {
        readonly Referee _referee;

        public CommandClient()
        {
            _referee = new Referee();
        }
        public void RunClientCode()
        {
            Console.WriteLine("***** START COMMAND *****");

            _referee.SetPenalty(new FirstPenaltyShooterCommand());

            _referee.Execute();
            _referee.Back();
            _referee.Execute();

            _referee.SetPenalty(new SecondPenaltyShooterCommand());
            _referee.Execute();

            Console.WriteLine("***** END COMMAND *****");
        }
    }
}