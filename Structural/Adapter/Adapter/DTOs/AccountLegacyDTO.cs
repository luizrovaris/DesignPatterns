using Adapter.Enumerator;
using System.Collections.Generic;

namespace Adapter.DTOs
{
    public class AccountLegacyDTO
    {
        public List<string> GetIdentificationMandatoryDocuments(CustomerType customerType)
        {
            var requiredDocuments = new List<string>();

            switch (customerType)
            {
                case CustomerType.Person:
                    {
                        requiredDocuments.Add("Federal Identification");
                        break;
                    }
                case CustomerType.Company:
                    {
                        requiredDocuments.Add("Certificate Of Incorporation");
                        break;
                    }
                case CustomerType.Staff:
                    {
                        requiredDocuments.Add("Employee Contract");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return requiredDocuments;
        }

        public List<string> GetFinancialMandatoryDocuments(CustomerType customerType)
        {
            var requiredDocuments = new List<string>();

            switch (customerType)
            {
                case CustomerType.Person:
                    {
                        requiredDocuments.Add("Final Payslip");
                        break;
                    }
                case CustomerType.Company:
                    {
                        requiredDocuments.Add("Balance Sheet");
                        break;
                    }
                case CustomerType.Staff:
                    {
                        requiredDocuments.Add("Leaf Discount");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return requiredDocuments;
        }

        public decimal GetCreditLimit(CustomerType customerType)
        {
            decimal creditLimit;
            switch (customerType)
            {
                case CustomerType.Person:
                    {
                        creditLimit = 3000;
                        break;
                    }
                case CustomerType.Company:
                    {
                        creditLimit = 50000;
                        break;
                    }
                case CustomerType.Staff:
                    {
                        creditLimit = 4000;
                        break;
                    }
                default:
                    {
                        creditLimit = 0;
                        break;
                    }
            }

            return creditLimit;
        }
    }
}
