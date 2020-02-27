namespace Builder.Build
{
    public class LoanProfile
    {
        public void SetProfile(LoanBuilder loanBuilder)
        {
            loanBuilder.AddFinancialMandatoryDocument();
            loanBuilder.AddIdentificationMandatoryDocument();
            loanBuilder.AddMaxLoanAmount();
        }
    }
}
