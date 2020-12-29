using Flyweight.Entity;
using Flyweight.Factory;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PropertyFactory();

            Property property = factory.GetProperty('I');
            property.Display();

            property = factory.GetProperty('M');
            property.Display();
        }
    }
}
