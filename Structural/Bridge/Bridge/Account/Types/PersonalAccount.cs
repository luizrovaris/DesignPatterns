using Bridge.DTO;
using Bridge.Enumerator;
using System.Collections.Generic;

namespace Bridge.Account.Types
{
	public class PersonalAccount : AccountDetail
	{
		public override void LoadData()
		{
			var account = new AccountDTO()
			{
				CustomerType = CustomerType.Person,
				MandatoryDocuments = new List<string>() { "Federal Identification", "Final Payslip" }
			};

			Account.LoadData(account);
		}
	}
}
