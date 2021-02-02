using System;

namespace Mediator.Colleague.Concrete
{
    public class NorthBankAgency : BankAgency
    {
        public NorthBankAgency(Mediator mediator)
            : base(mediator)
        {
            this.Code = "N001";
            this.Name = "North Agency";
        }

        public void ChangeCustomerAgency(BankAgency newAgency)
        {
            Console.WriteLine($"NorthInfo: Changing agency {this.Name} to {newAgency.Name}.");
            base._mediator.ChangeCustomerAgency(this, newAgency);
        }

        public void ConfirmAgencyChange(BankAgency newAgency)
        {
            Console.WriteLine($"NorthInfo: Agency changed to {newAgency.Name}.");
        }
    }
}
