using Mediator.Colleague;

namespace Mediator
{
    public interface Mediator
    {
        void ChangeCustomerAgency(BankAgency currentAgency, BankAgency newAgency);
    }
}
