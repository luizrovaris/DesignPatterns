using Mediator.Colleague.Concrete;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new BankAgencyMediator();

            var southBankAgency = new SouthBankAgency(mediator);
            var northBankAgency = new NorthBankAgency(mediator);

            mediator.SouthBankAgency = southBankAgency;
            mediator.NorthBankAgency = northBankAgency;            

            Console.ReadKey();
        }
    } 
}