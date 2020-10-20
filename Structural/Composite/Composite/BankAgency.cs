using System;
using System.Collections.Generic;

namespace Composite
{
    public abstract class BankAgency
    {
        public BankAgency(string code, string name)
        {
            this.Code = code;
            this.Name = name;
            this.SubAgencies = new List<BankAgency>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public List<BankAgency> SubAgencies { get; set; }

        public void Display(string displaySpace = "")
        {
            Console.WriteLine($"{displaySpace}{this.Code} - {this.Name}");
            foreach (BankAgency agency in this.SubAgencies)
            {
                agency.Display(displaySpace + " ");
            }
        }
    }
}
