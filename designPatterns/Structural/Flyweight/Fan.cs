using designPatterns.Structural.Flyweight.Abstracts;

namespace designPatterns.Structural.Flyweight
{
    public class Fan : IFlyweightFan
    {
        public int Id { get; }
        private string _firstName;
        private string _lastName;
        private string _team;

        public Fan(int id, string firstName, string lastName, string team)
        {
            Id = id;
            _firstName = firstName;
            _lastName = lastName;
            _team = team;
        }

        public string GetInfo() => $"{_firstName} {_lastName} is {_team} fan.";
    }
}
