namespace MyGame
{
    public class AccountRepotitory : IAccountRepository
    {
        private DbContext context;
        public AccountRepotitory(DbContext dbContext)
        {
            context = dbContext;
        }
        public GameAccount Create(string type, string name)
        {
            GameAccount player = new AccountFactory().MakeAccount(type, name);
            context.CreateAccount(player);
            return player;
        }
        public IEnumerable<GameAccount> GetAllPlayers()
        {
            return context.PlayerDB;
        }
        public GameAccount GetById(int id)
        {   
            return context.GetById(id);
        }
        public GameAccount GetAccountByName(string name)
        {
            IEnumerable<GameAccount> allAccounts = GetAllPlayers();
            foreach(GameAccount account in allAccounts)
            {
                if(account.UserName == name)
                {
                    return account;
                }
            }
            throw new Exception("Account with given name does not exist");

        }
    }
}