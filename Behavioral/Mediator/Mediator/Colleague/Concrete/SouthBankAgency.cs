using System;

namespace Mediator.Colleague.Concrete
{
    public class SouthBankAgency : BankAgency
    {
        public SouthBankAgency(Mediator mediator)
            : base(mediator)
        {
        }

        public void ChangeCustomerAgency(BankAgency newAgency)
        {
            Console.WriteLine($"SouthInfo: Changing agency {this.Name} to {newAgency.Name}.");
            base._mediator.ChangeCustomerAgency(this, newAgency);
        }

        public void ConfirmAgencyChange(BankAgency newAgency)
        {
            Console.WriteLine($"SouthInfo: Agency changed to {newAgency.Name}.");
        }
    }
}
