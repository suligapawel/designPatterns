using designPatterns.Structural.Decorator.Abstracts;
using designPatterns.Structural.Decorator.Decorators;
using System;

namespace designPatterns.Structural.Decorator
{
    public class DecoratorClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START DECORATOR *****");

            ITicket ticket = new SimpleTicket();

            Console.WriteLine("--- SIMPLE TICKET ---");
            Console.WriteLine(ticket.Name);
            Console.WriteLine(ticket.CalculatePrice());

            ticket = new HotDogDecorator(ticket);

            Console.WriteLine("--- HOT-DOG + TICKET ---");
            Console.WriteLine(ticket.Name);
            Console.WriteLine(ticket.CalculatePrice());

            ticket = new ColaDecorator(ticket);

            Console.WriteLine("--- COLA + HOT-DOG + TICKET ---");
            Console.WriteLine(ticket.Name);
            Console.WriteLine(ticket.CalculatePrice());

            ticket = new SportGadgetDecorator(ticket);

            Console.WriteLine("--- GADGET + COLA + HOT-DOG + TICKET ---");
            Console.WriteLine(ticket.Name);
            Console.WriteLine(ticket.CalculatePrice());

            Console.WriteLine("***** END DECORATOR *****");
        }
    }
}
