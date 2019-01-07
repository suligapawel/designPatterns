using designPatterns.Structural.Composite.Components;
using System;

namespace designPatterns.Structural.Composite
{
    public class CompositeClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START COMPOSITE *****");

            var managerRoot = new ManagerComposite("Diego Simeone", false);

            var goalkeepersTrainer = new TrainerComposite("GoalKeepers Trainer", false);
            var defendersTrainer = new TrainerComposite("Defenders Trainer", false);
            var midfieldersTrainer = new TrainerComposite("Midfielders Trainer", false);
            var attackersTrainer = new TrainerComposite("Attackers Trainer", false);

            managerRoot.AddChild(goalkeepersTrainer);
            managerRoot.AddChild(defendersTrainer);
            managerRoot.AddChild(midfieldersTrainer);
            managerRoot.AddChild(attackersTrainer);

            goalkeepersTrainer.AddChild(new FootballerLeaf("Jan Oblak", true));

            defendersTrainer.AddChild(new FootballerLeaf("Stefan Savic", true));
            defendersTrainer.AddChild(new FootballerLeaf("Diego Godin", true));
            defendersTrainer.AddChild(new FootballerLeaf("Filipe Luis", true));
            defendersTrainer.AddChild(new FootballerLeaf("Juanfran", true));

            midfieldersTrainer.AddChild(new FootballerLeaf("Saul Niguez", true));
            midfieldersTrainer.AddChild(new FootballerLeaf("Koke", true));
            midfieldersTrainer.AddChild(new FootballerLeaf("Thomas", true));
            midfieldersTrainer.AddChild(new FootballerLeaf("Vitolo", true));

            attackersTrainer.AddChild(new FootballerLeaf("Antoine Griezmann", true));
            attackersTrainer.AddChild(new FootballerLeaf("Diego Costa", true));

            managerRoot.Operation();

            Console.WriteLine("***** END COMPOSITE *****");
        }
    }
}
