using System;
using designPatterns.Creational.Builder.ConcreteBuilders;

namespace designPatterns.Creational.Builder
{
    public class BuilderClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START BUILDER *****");

            Director director = new Director(new StarContractBuilder(18));

            Contract youngStarContract = director.GenerateContract();
            Console.WriteLine(youngStarContract.ShowContract());

            director.SetNewBuilder(new StarContractBuilder(33));
            Contract oldStarContract = director.GenerateContract();
            Console.WriteLine(oldStarContract.ShowContract());

            director.SetNewBuilder(new ProfessionalContractBuilder());
            Contract professionalContract = director.GenerateContract();
            Console.WriteLine(professionalContract.ShowContract());

            director.SetNewBuilder(new AmatorContractBuilder());
            Contract amatorContract = director.GenerateContract();
            Console.WriteLine(amatorContract.ShowContract());

            Console.WriteLine("***** END BUILDER ******");
        }
    }
}