using AbstractFactory.Entities;
using AbstractFactory.Entities.Base;
using AbstractFactory.Factory.Base;
using System;

namespace AbstractFactory.Factory
{
    public class CompanyFactory : CustomerFactory
    {
        public override Customer GetCustomer(Guid id)
        {
            //MOCK
            return new Company()
            {
                Id = id,
                Employees = new Random().Next(200, 10000),
                Name = "Random Company"
            };
        }
    }
}
