using Prototype.Enumerator;
using Prototype.Prototype;
using System.Collections.Generic;

namespace Prototype
{
    class AccountMenu
    {
        private Dictionary<AccountTypes, AccountPrototype> account = new Dictionary<AccountTypes, AccountPrototype>();

        public AccountPrototype this[AccountTypes type]
        {
            get { return account[type]; }
            set { account.Add(type, value); }
        }
    }
}
