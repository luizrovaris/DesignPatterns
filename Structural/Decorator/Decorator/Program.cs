using Decorator.Component;
using Decorator.Concrete;
using Decorator.Decorator;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalLoanMandatoryDocuments = new List<string>() { "Federal Identification", "Final Payslip" };
            LoanComponent personalLoan = new PersonLoan(personalLoanMandatoryDocuments, 50000);
            
            var companyLoanMandatoryDocuments = new List<string>() { "Certificate Of Incorporation", "Balance Sheet" };
            string companyType = "Limited Liability Company";//Sole Proprietorship / Partnership / Limited Liability Company (LLC)
            LoanComponent companyLoan = new CompanyLoan(companyLoanMandatoryDocuments, 10000000, companyType);

            var personalLoanAvaiability = new LoanAvailability(personalLoan, 100000);
            var companyLoanAvaiability = new LoanAvailability(companyLoan, 20000000);

            personalLoanAvaiability.LoanProposal("Joana Oliveira");
            personalLoanAvaiability.LoanProposal("Antônio Pedroso");
            personalLoanAvaiability.LoanProposal("Gabriela Moura");

            companyLoanAvaiability.LoanProposal("Square Inc");
            companyLoanAvaiability.LoanProposal("Green Corp");
            companyLoanAvaiability.LoanProposal("Trace LLC");

            personalLoanAvaiability.Display();
            companyLoanAvaiability.Display();
        }
    }
}
