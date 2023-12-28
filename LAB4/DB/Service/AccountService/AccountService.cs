namespace MyGame
{
    public class AccountService : IAccountService
    {
        public IAccountRepository repository;
        public AccountService(DbContext context)
        {
            repository = new AccountRepotitory(context);
        }
        public GameAccount CreateAccount(string type, string name)
        {
            GameAccount player = repository.Create(type, name);
            return player;
        }
        public void ReadAccounts()
        {
            System.Console.WriteLine("All accounts:");
            foreach(GameAccount player in repository.GetAllPlayers())
            {
                System.Console.WriteLine($"{player.UserName} Current Rating {player.CurrentRating}");
            }
            System.Console.WriteLine();
        }
        public GameAccount GetAccountByName(string name)
        {
            return repository.GetAccountByName(name);
        }
    }
}