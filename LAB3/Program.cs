namespace MyGame 
{
    public class GameExample 
    {
        static void Main() 
        {
            Account account = new Account();
            account.name = "max";
            account.score = 1;
            account.id = 1;
        List<Account> list = new ();
        AccountRepository repository = new (list);
        AccountService service = new (repository);
        service.CreateAccount(account);
        System.Console.WriteLine(service.ReadAccounts());

        }
    }
}