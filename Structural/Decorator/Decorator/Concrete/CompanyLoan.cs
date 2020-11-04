using Decorator.Component;
using System;
using System.Collections.Generic;

namespace Decorator.Concrete
{
	public class CompanyLoan : LoanComponent
    {
		public List<string> mandatoryDocuments;
		public string companyType;

		public CompanyLoan(List<string> mandatoryDocuments, decimal loanAmount, string companyType)
		{
			this.mandatoryDocuments = mandatoryDocuments;
			base.LoanAmount = loanAmount;
			this.companyType = companyType;
		}

		public override void Display()
		{
			Console.WriteLine($"\nCompany Loan - {this.companyType}:");
			Console.WriteLine("Mandatory Documents");

			foreach (string mandatoryDocument in this.mandatoryDocuments)
			{
				Console.WriteLine($"	- {mandatoryDocument}");
			}

			Console.WriteLine($"Loan Amount - {base.LoanAmount}");
		}
	}
}
