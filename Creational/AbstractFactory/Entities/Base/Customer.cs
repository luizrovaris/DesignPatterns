using System;

namespace AbstractFactory.Entities.Base
{
    public abstract class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
