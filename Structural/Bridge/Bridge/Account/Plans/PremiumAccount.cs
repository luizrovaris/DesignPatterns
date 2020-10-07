using Bridge.DTO;
using System;

namespace Bridge.Account.Plans
{
    public class PremiumAccount : IAccountSystem
    {
        public void LoadData(AccountDTO account)
        {
            Console.WriteLine($"\nPremium account - {account.CustomerType.ToString()}");
            Console.WriteLine("*Must have basic account for 3 years.");
            Console.WriteLine($"Mandatory Documents: {string.Join(',', account.MandatoryDocuments)}");
        }
    }
}
