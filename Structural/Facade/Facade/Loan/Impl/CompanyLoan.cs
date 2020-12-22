using Facade.Entity;

namespace Facade.Loan.Impl
{
    public class CompanyLoan : ILoanFacade
    {
        public LoanItem GetLoan(int loanId)
        {
            return new LoanItem()
            {
                LoanId = loanId
            };
        }
    }
}
