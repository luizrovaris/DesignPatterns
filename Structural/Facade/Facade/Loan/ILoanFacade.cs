using Facade.Entity;

namespace Facade.Loan
{
    public interface ILoanFacade
    {
        LoanItem GetLoan(int loanId);
    }
}
