namespace Facade.Entity
{
    public class Customer
    {
        private string _name;

        public Customer(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
