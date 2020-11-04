using Decorator.Component;
using System;
using System.Collections.Generic;

namespace Decorator.Concrete
{
	public class PersonLoan : LoanComponent
    {
		public List<string> mandatoryDocuments;

		public PersonLoan(List<string> mandatoryDocuments, decimal loanAmount)
		{
			this.mandatoryDocuments = mandatoryDocuments;
			base.LoanAmount = loanAmount;
		}

		public override void Display()
		{
			Console.WriteLine("\nPerson Loan:");
			Console.WriteLine("Mandatory Documents");

			foreach (string mandatoryDocument in this.mandatoryDocuments)
			{
				Console.WriteLine($"	- {mandatoryDocument}");
			}

			Console.WriteLine($"Loan Amount - {base.LoanAmount}");
		}
	}
}
