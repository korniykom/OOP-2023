namespace MyGame
{
    public class AccountRepotitory : IAccountRepository
    {
        private DbContext context;
        public AccountRepotitory()
        {
            context = new ();

        }
        public IEnumerable<GameAccount> GetAllPlayers()
        {
            return context.PlayerDB;
        }
        public GameAccount GetById(int id)
        {
            return context.PlayerDB.FirstOrDefault(player => player.id == id);  
        }
        public GameAccount Create(string type, string name)
        {
            GameAccount player = new AccountFactory().MakeAccount(type, name);
            context.PlayerDB.Add(player);
            return player;
        }
        public void UpdateName(int id, string name)
        {
            GameAccount currentPlayer = this.GetById(id);
            currentPlayer.UserName = name;
        }
    }
}