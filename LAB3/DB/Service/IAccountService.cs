namespace MyGame
{
    public interface IAccountService
    {
        public void CreateAccount(Account account);
        public IEnumerable<Account> ReadAccounts();
        public Account ReadAccountById(int id);
        

    }
}