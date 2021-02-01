namespace Mediator.Colleague
{
    public abstract class BankAgency
    {
        protected Mediator _mediator;


        public BankAgency(Mediator mediator)
        {
            this._mediator = mediator;
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }
}
