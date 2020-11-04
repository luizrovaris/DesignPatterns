namespace Decorator.Component
{
    public abstract class LoanComponent
    {
        public decimal LoanAmount { get; set; }
        public abstract void Display();
    }
}
