using Bridge.DTO;
using Bridge.Enumerator;
using System.Collections.Generic;

namespace Bridge.Account.Types
{
	public class StaffAccount : AccountDetail
	{
		public override void LoadData()
		{
			var account = new AccountDTO()
			{
				CustomerType = CustomerType.Staff,
				MandatoryDocuments = new List<string>() { "Employee Contract", "Leaf Discount" }
			};

			Account.LoadData(account);
		}
	}
}
