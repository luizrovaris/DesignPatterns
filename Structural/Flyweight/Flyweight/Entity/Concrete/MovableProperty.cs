using System;

namespace Flyweight.Entity.Concrete
{
    public class MovableProperty : Property
    {
        public MovableProperty()
        {
            this.Name = "Car";
            this.Value = 2000;
        }
        public override void Display()
        {
            Console.WriteLine($"Movable Property: {this.Name} ({this.Value})");
        }
    }
}
