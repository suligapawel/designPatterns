using designPatterns.Structural.Proxy.Abstracts;
using System;

namespace designPatterns.Structural.Proxy
{
    public class ProxyClient : IClient
    {
        public void RunClientCode()
        {
            Console.WriteLine("***** START PROXY *****");

            ISalary manager = new ManagerProxy(2, 3);
            decimal salary = manager.WithdrawPayment();

            Console.WriteLine($"Summary: {salary:C}");

            Console.WriteLine("***** END PROXY *****");
        }
    }
}
