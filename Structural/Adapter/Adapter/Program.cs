using Adapter.DTOs;
using Adapter.Enumerator;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non-Adapted:");
            var nonAdaptedPerson = new AccountDTO(CustomerType.Person);
            nonAdaptedPerson.Display();

            Console.WriteLine("\n\nAdapted:");
            var person = new AccountDetailDTO(CustomerType.Person);
            person.Display();
            var company = new AccountDetailDTO(CustomerType.Company);
            company.Display();
            var staff = new AccountDetailDTO(CustomerType.Staff);
            staff.Display();
        }
    }
}
