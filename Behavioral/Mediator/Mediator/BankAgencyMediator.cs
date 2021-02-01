using Mediator.Colleague;
using Mediator.Colleague.Concrete;

namespace Mediator
{
    public class BankAgencyMediator : Mediator
    {
        private NorthBankAgency _northBankAgency;
        private SouthBankAgency _southBankAgency;

        public NorthBankAgency NorthBankAgency
        {
            set { _northBankAgency = value; }
        }

        public SouthBankAgency SouthBankAgency
        {
            set { _southBankAgency = value; }
        }

        public void ChangeCustomerAgency(BankAgency currentAgency, BankAgency newAgency)
        {
            if (newAgency == _northBankAgency)
            {
                _southBankAgency.ConfirmAgencyChange(newAgency);
            }
            else
            {
                _northBankAgency.ConfirmAgencyChange(newAgency);
            }
        }
    }
}
