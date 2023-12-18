namespace MyGame
{
    public class AccountRepotitory : IAccountRepository
    {
        private DbContext context;
        public AccountRepotitory()
        {
            context = new ();
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
    }
}