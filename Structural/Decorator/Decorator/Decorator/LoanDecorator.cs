using Decorator.Component;

namespace Decorator.Decorator
{
	public abstract class LoanDecorator : LoanComponent
	{
		protected LoanComponent loanComponent;

		public LoanDecorator(LoanComponent loanComponent)
		{
			this.loanComponent = loanComponent;
		}

		public override void Display()
		{
			this.loanComponent.Display();
		}
	}
}
