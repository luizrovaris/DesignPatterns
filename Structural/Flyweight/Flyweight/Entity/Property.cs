namespace Flyweight.Entity
{
    public abstract class Property
    {
        protected string Name { get; set; }
        protected decimal Value { get; set; }

        public abstract void Display();
    }
}
