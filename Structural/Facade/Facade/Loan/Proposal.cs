using Facade.Entity;

namespace Facade.Loan
{
    public  class Proposal
    {
        public LoanItem CompanyLoan { get; set; }
        public LoanItem PersonLoan { get; set; }
    }
}
