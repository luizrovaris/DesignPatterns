using Facade.Entity;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var proposal = new Proposal();

            Console.Write("Customer name: ");
            string name = Console.ReadLine();

            var customer = new Customer(name);

            proposal.CreateAccount(customer, Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        }
    }
}
