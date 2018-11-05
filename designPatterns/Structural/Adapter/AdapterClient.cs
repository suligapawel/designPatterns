using System;
using designPatterns.Structural.Adapter.Abstracts;
using designPatterns.Structural.Adapter.Handlers;

namespace designPatterns.Structural.Adapter
{
    public class AdapterClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START ADAPTER *****");

            TranslatorAdapter adapter = new TranslatorAdapter(new GermanFootballer());
            adapter.GiveInterviewInPolish();

            Console.WriteLine("***** END ADAPTER *****");
        }
    }
}