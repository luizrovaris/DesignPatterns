using Bridge.DTO;
using Bridge.Enumerator;
using System.Collections.Generic;

namespace Bridge.Account.Types
{
	public class CorporateAccount : AccountDetail
	{
		public override void LoadData()
		{
			var account = new AccountDTO()
			{
				CustomerType = CustomerType.Company,
				MandatoryDocuments = new List<string>() { "Certificate of Incorporation", "Balance Sheet" }
			};

			Account.LoadData(account);
		}
	}
}
