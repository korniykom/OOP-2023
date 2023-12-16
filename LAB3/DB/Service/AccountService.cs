namespace MyGame
{
    public class AccountService
    {
        private AccountRepository accountRepository;
        public AccountService(AccountRepository repository)
        {
            accountRepository = repository;
        }
        public void CreateAccount (Account account)
        {
            accountRepository.Add(account);
        }
        public IEnumerable<Account> ReadAccounts()
        {
            return accountRepository.GetAll();
        }
    }
}