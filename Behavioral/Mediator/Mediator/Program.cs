using Mediator.Colleague.Concrete;
using Mediator.Entity;

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

            var customer = new Customer()
            {
                BankAgency = southBankAgency,
                IdentificationNumber = "1234",
                Name = "Customer Test"
            };

            customer.Display();

            customer.BankAgency = southBankAgency.ChangeCustomerAgency(northBankAgency);

            customer.Display();
        }
    } 
}