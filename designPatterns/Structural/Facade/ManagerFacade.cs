using designPatterns.Structural.Facade.Subclasses;

namespace designPatterns.Structural.Facade
{
    public class ManagerFacade
    {
        private readonly WarmupTrainer _warmupTrainer;
        private readonly TacticTrainer _tacticTrainer;
        private readonly SecondManager _secondManager;

        public ManagerFacade()
        {
            _warmupTrainer = new WarmupTrainer();
            _tacticTrainer = new TacticTrainer();
            _secondManager = new SecondManager();
        }

        public void MakeFootballerChange(int takeOffNumber, int enterNumber)
        {
            Footballer takeOffFootballer = new Footballer(takeOffNumber);
            Footballer enterFootballer = new Footballer(enterNumber);

            _warmupTrainer.WarmUpPlayer(enterFootballer);
            _tacticTrainer.ExplainTactic(enterFootballer);
            _secondManager.ReportChangeToTechnicalReferee(takeOffFootballer, enterFootballer);
        }
    }
}