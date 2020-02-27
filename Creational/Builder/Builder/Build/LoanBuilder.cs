using Builder.Entities;
using Builder.Enumerator;

namespace Builder.Build
{
    public abstract class LoanBuilder
    {
        protected Customer customer;

        public LoanBuilder(CustomerType customerType)
        {
            this.customer = new Customer(customerType);
        }

        public Customer Customer
        {
            get { return this.customer; }
        }

        public abstract void AddIdentificationMandatoryDocument();
        public abstract void AddFinancialMandatoryDocument();
        public abstract void AddMaxLoanAmount();
    }
}
