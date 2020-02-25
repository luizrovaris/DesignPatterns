using AbstractFactory.Entities;
using AbstractFactory.Entities.Base;
using AbstractFactory.Factory.Base;
using System;

namespace AbstractFactory.Factory
{
    public class PersonFactory : CustomerFactory
    {
        public override Customer GetCustomer(Guid id)
        {
            //MOCK
            return new Person()
            {
                Id = id,
                Age = new Random().Next(21, 55),
                Name = "Random Person"
            };
        }
    }
}
