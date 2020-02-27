using Builder.Build;
using Builder.Enumerator;

namespace Builder.Entities
{
    public class CompanyLoan : LoanBuilder
    {
        public CompanyLoan()
            : base(CustomerType.Company)
        {
        }

        public override void AddIdentificationMandatoryDocument()
        {
            base.customer.SetMandatoryDocument("Certificate Of Incorporation");            
        }

        public override void AddFinancialMandatoryDocument()
        {
            base.customer.SetMandatoryDocument("Balance Sheet");
        }

        public override void AddMaxLoanAmount()
        {
            base.customer.SetMaxLoanAmount(10000000);
        }
    }
}
