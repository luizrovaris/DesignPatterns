using Mediator.Colleague;

namespace Mediator.Entity
{
    public class Customer
    {
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public BankAgency BankAgency { get; set; }
    }
}
