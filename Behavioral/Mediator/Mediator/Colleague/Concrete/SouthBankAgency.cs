using System;

namespace Mediator.Colleague.Concrete
{
    public class SouthBankAgency : BankAgency
    {
        public SouthBankAgency(Mediator mediator)
            : base(mediator)
        {
            this.Code = "S001";
            this.Name = "South Agency";
        }

        public BankAgency ChangeCustomerAgency(BankAgency newAgency)
        {
            Console.WriteLine($"SouthInfo: Changing agency {this.Name} to {newAgency.Name}.");
            base._mediator.ChangeCustomerAgency(this, newAgency);
            return newAgency;
        }

        public void ConfirmAgencyChange(BankAgency newAgency)
        {
            Console.WriteLine($"SouthInfo: Agency changed to {newAgency.Name}.");
        }
    }
}
