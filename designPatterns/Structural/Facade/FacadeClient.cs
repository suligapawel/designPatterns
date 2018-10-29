using System;

namespace designPatterns.Structural.Facade
{
    public class FacadeClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START FACADE *****");

            ManagerFacade facade = new ManagerFacade();
            facade.MakeFootballerChange(7, 99);

            Console.WriteLine("***** END FACADE *****");
        }
    }
}