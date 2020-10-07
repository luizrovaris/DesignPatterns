using Bridge.Account;
using Bridge.Account.Plans;
using Bridge.Account.Types;

namespace Bridge
{
	class Program
    {
        static void Main(string[] args)
        {
			//Type: Personal; Plan: Basic
			AccountDetail accountDetail = new PersonalAccount();
			accountDetail.Account = new BasicAccount();
			accountDetail.LoadData();

			//Type: Personal; Plan: Premium
			accountDetail.Account = new PremiumAccount();
			accountDetail.LoadData();

			//Type: Corporate; Plan: Basic
			accountDetail = new CorporateAccount();
			accountDetail.Account = new BasicAccount();
			accountDetail.LoadData();

			//Type: Corporate; Plan: Premium
			accountDetail.Account = new PremiumAccount();
			accountDetail.LoadData();

			//Type: Staff; Plan: Basic
			accountDetail = new StaffAccount();
			accountDetail.Account = new BasicAccount();
			accountDetail.LoadData();

			//Type: Staff; Plan: Premium
			accountDetail.Account = new PremiumAccount();
			accountDetail.LoadData();
		}
    }
}
