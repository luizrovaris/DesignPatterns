using AbstractFactory.Entities;
using AbstractFactory.Factory;
using AbstractFactory.Factory.Base;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = null;
            Person person = null;
            CustomerFactory customerFactory = null;

            customerFactory = new CompanyFactory();
            company = (Company)customerFactory.GetCustomer(Guid.NewGuid());

            customerFactory = new PersonFactory();
            person = (Person)customerFactory.GetCustomer(Guid.NewGuid());

            Console.WriteLine($"Person: {person.Name}. Id: {person.Id}. Age: {person.Age}");
            Console.WriteLine($"Company: {company.Name}. Id: {company.Id}. Employees: {company.Employees}");

            Console.Read();
        }
    }
}
