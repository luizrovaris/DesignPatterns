using Decorator.Component;
using System;
using System.Collections.Generic;

namespace Decorator.Decorator
{
    public class LoanAvailability : LoanDecorator
    {
        public decimal AmountAvailable { get; set; }
        public LoanComponent LoanComponent { get; set; }

        protected List<string> customers = new List<string>();

        public LoanAvailability(LoanComponent loanComponent, decimal amountAvailable)
            : base(loanComponent)
        {
            this.AmountAvailable = amountAvailable;
            this.LoanComponent = loanComponent;
        }

        public void LoanProposal(string name)
        {
            if (this.AmountAvailable >= this.LoanComponent.LoanAmount)
            {
                this.customers.Add(name);
                this.AmountAvailable -= this.LoanComponent.LoanAmount;
            }
            else
            {
                Console.WriteLine("\nNo amount available!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (var customer in customers)
            {
                Console.WriteLine("Proposal created by " + customer);
            }
        }
    }
}
