using Facade.Entity;

namespace Facade.Loan.Impl
{
    public class PersonLoan : ILoanFacade
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
