namespace MyGame
{
    public class ShowAccounts : ICommand
    {
        private DbContext db;
        public ShowAccounts(DbContext context)
        {
            db = context;
        }
        public string ShowInfo() 
        {
            return "Show all players";
        }
        public void DoSmth()
        {
            IAccountService service = new AccountService (db);
            service.ReadAccounts();
        }
    }
}