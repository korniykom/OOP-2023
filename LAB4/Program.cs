namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            DbContext db = new DbContext ();

            IAccountService accountService = new AccountService(db);
            GameAccount player1 = accountService.CreateAccount("premium", "Max");
            GameAccount player2 = accountService.CreateAccount("premium", "John");
            GameAccount player3 = accountService.CreateAccount("regular", "Alan");


            CreateAccount newAcc = new CreateAccount(db);
            newAcc.DoSmth();
            accountService.ReadAccounts();

                        accountService.ReadAccounts();

            
        }
    }
}