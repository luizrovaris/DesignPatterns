using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities
{
    public class Company : Customer
    {
        public int Employees { get; set; }
    }
}
