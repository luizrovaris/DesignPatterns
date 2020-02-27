using Builder.Build;
using Builder.Entities;
using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            LoanBuilder loanBuilder;

            var loanProfile = new LoanProfile();

            loanBuilder = new CompanyLoan();
            loanProfile.SetProfile(loanBuilder);
            Console.WriteLine(loanBuilder.Customer.GetMadatoryDocuments());
            Console.WriteLine(loanBuilder.Customer.GetMaxLoanAmount());

            loanBuilder = new PersonLoan();
            loanProfile.SetProfile(loanBuilder);
            Console.WriteLine(loanBuilder.Customer.GetMadatoryDocuments());
            Console.WriteLine(loanBuilder.Customer.GetMaxLoanAmount());

            loanBuilder = new StaffLoan();
            loanProfile.SetProfile(loanBuilder);
            Console.WriteLine(loanBuilder.Customer.GetMadatoryDocuments());
            Console.WriteLine(loanBuilder.Customer.GetMaxLoanAmount());

            Console.ReadKey();
        }
    }
}
