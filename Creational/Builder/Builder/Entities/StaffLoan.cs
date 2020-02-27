using Builder.Build;
using Builder.Enumerator;

namespace Builder.Entities
{
    public class StaffLoan : LoanBuilder
    {
        public StaffLoan()
            : base(CustomerType.Staff)
        {
        }

        public override void AddIdentificationMandatoryDocument()
        {
            base.customer.SetMandatoryDocument("Employee Contract");
        }

        public override void AddFinancialMandatoryDocument()
        {
            base.customer.SetMandatoryDocument("Leaf Discount");
        }

        public override void AddMaxLoanAmount()
        {
            base.customer.SetMaxLoanAmount(115000);
        }
    }
}
