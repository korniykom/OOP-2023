namespace MyGame
{
    public class CreateAccount
    {
        private DbContext context;
        public CreateAccount(DbContext db)
        {
            context = db;
        }
        public void DoSmth()
        {
            System.Console.WriteLine("Enter account name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter account type");
            string type = Console.ReadLine();

            IAccountService accountService = new AccountService(context);
            GameAccount player = accountService.CreateAccount(type, name);    
        }
    }
}