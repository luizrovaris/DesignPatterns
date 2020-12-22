using Facade.Account;
using Facade.Account.Impl;
using Facade.Entity;
using System;

namespace Facade
{
    public class Proposal
    {
        private CompanyAccount companyAccount = new CompanyAccount();
        private PersonAccount personAccount = new PersonAccount();
        public AccountDetail CreateAccount(Customer customer, string corporateCreditCard, string personalCreditCard)
        {
            Console.WriteLine($"Customer: {customer.Name}, credit card: {corporateCreditCard}, debit card: {personalCreditCard}.");

            var accountDetail = new AccountDetail()
            {
                CorporateCreditCard = this.companyAccount.GetAccountItem(corporateCreditCard),
                PersonalCreditCard = this.personAccount.GetAccountItem(personalCreditCard)
            };

            return accountDetail;
        }
    }
}
