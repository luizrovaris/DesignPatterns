using Facade.Entity;

namespace Facade.Account.Impl
{
    public class PersonAccount : IAccountFacade
    {
        public AccountItem GetAccountItem(string itemId)
        {
            return new AccountItem()
            {
                Id = itemId
            };
        }
    }
}
