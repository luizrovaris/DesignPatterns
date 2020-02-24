using AbstractFactory.Entities.Base;
using System;

namespace AbstractFactory.Factory.Base
{
    public abstract class CustomerFactory
    {
        public abstract Customer GetCustomer(Guid id);
    }
}
