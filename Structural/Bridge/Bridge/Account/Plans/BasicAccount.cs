using Bridge.DTO;
using System;

namespace Bridge.Account.Plans
{
    public class BasicAccount : IAccountSystem
    {
        public void LoadData(AccountDTO account)
        {
            Console.WriteLine($"\nBasic account - {account.CustomerType.ToString()}");
            Console.WriteLine($"Mandatory Documents: {string.Join(',', account.MandatoryDocuments)}");
        }
    }
}
