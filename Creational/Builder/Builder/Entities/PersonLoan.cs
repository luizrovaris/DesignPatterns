using Builder.Build;
using Builder.Enumerator;

namespace Builder.Entities
{
    public class PersonLoan : LoanBuilder
    {
        public PersonLoan()
            : base(CustomerType.Person)
        {
        }

        public override void AddIdentificationMandatoryDocument()
        {
            base.customer.SetMandatoryDocument("Federal Identification");
        }

        public override void AddFinancialMandatoryDocument()
        {
            base.customer.SetMandatoryDocument("Final Payslip");
        }

        public override void AddMaxLoanAmount()
        {
            base.customer.SetMaxLoanAmount(99000);
        }
    }
}
