using Prototype.Enumerator;
using Prototype.Prototype;
using System;

namespace Prototype.Concrete
{
    public class Account : AccountPrototype
    {
        private string accountDescription;
        private string requiredDocument;
        private string accountNumber;
        private string customerName;

        public Account(string accountDescription, string requiredDocument)
        {
            this.accountDescription = accountDescription;
            this.requiredDocument = requiredDocument;
        }

        public void SetPersonalData(string accountNumber, string customerName)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
        }

        public void Display()
        {
            if (string.IsNullOrEmpty(this.accountNumber))
            {
                Console.WriteLine($"{this.accountDescription} - {this.requiredDocument}");
            }
            else
            {
                Console.WriteLine($"{this.accountDescription} - {this.accountNumber} - {this.customerName}");
            }
        }

        public override AccountPrototype Clone()
        {
            return MemberwiseClone() as AccountPrototype;
        }
    }
}
