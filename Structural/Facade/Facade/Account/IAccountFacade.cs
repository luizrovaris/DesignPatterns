using Facade.Entity;

namespace Facade.Account
{
    public interface IAccountFacade
    {
        AccountItem GetAccountItem(string Id);
    }
}
