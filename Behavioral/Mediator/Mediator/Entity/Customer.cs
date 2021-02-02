using Mediator.Colleague;
using System;

namespace Mediator.Entity
{
    public class Customer
    {
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public BankAgency BankAgency { get; set; }

        internal void Display()
        {
            Console.WriteLine($"Customer: {this.IdentificationNumber} - {this.Name}. Agency: {this.BankAgency.Code}-{this.BankAgency.Name}");
        }
    }
}
