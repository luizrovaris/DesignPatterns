using System;

namespace Flyweight.Entity.Concrete
{
    public class ImmovableProperty : Property
    {
        public ImmovableProperty()
        {
            this.Name = "House";
            this.Value = 500000;
        }
        public override void Display()
        {
            Console.WriteLine($"Immovable Property: {this.Name} ({this.Value})");
        }
    }
}
