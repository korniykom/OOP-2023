namespace MyGame
{
    public class AccountService : IAccountService
    {
        public IAccountRepository repository = new AccountRepotitory();
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
                System.Console.WriteLine($"{player.UserName}");
            }
            System.Console.WriteLine();
        }
    }
}