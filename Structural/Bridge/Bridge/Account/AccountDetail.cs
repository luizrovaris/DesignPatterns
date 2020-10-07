namespace Bridge.Account
{
    public abstract class AccountDetail
    {
        public IAccountSystem Account;

        public abstract void LoadData();
    }
}
