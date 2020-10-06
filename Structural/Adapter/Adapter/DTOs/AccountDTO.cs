using Adapter.Enumerator;
using System;
using System.Collections.Generic;

namespace Adapter.DTOs
{
    public class AccountDTO
    {
        public AccountDTO(CustomerType customerType)
        {
            this.CustomerType = customerType;
            this.MandatoryDocuments = new List<string>();
        }

        public CustomerType CustomerType { get; set; }
        public List<string> MandatoryDocuments { get; set; }
        public decimal CreditLimit { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"\nCustomer Type: {this.CustomerType.ToString()}");
        }
    }
}
