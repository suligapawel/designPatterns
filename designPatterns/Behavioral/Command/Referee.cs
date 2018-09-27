using designPatterns.Behavioral.Command.Abstracts;

namespace designPatterns.Behavioral.Command
{
    public class Referee
    {
        private IFootballerCommand _footballer;

        public void SetPenalty(IFootballerCommand footballer){
            _footballer = footballer;
        }

        public void Execute(){
            _footballer.Shoot();
        }

        public void Back(){
            _footballer.Back();
        }
    }
}