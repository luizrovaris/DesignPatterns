using Adapter.Enumerator;
using System;

namespace Adapter.DTOs
{
    public class AccountDetailDTO : AccountDTO
    {
        public AccountDetailDTO(CustomerType customerType)
            : base(customerType)
        {

        }

        public override void Display()
        {
            var accountLegacyDTO = new AccountLegacyDTO();

            base.MandatoryDocuments.AddRange(accountLegacyDTO.GetIdentificationMandatoryDocuments(base.CustomerType));
            base.MandatoryDocuments.AddRange(accountLegacyDTO.GetFinancialMandatoryDocuments(base.CustomerType));
            base.CreditLimit = accountLegacyDTO.GetCreditLimit(base.CustomerType);

            base.Display();
            Console.WriteLine($"Mandatory Documents: {string.Join('-', base.MandatoryDocuments)}");
            Console.WriteLine($"Credit Limit: {base.CreditLimit}");
        }
    }
}
