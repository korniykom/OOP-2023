namespace MyGame
{
    public interface IAccountService
    {
        public GameAccount CreateAccount(string type, string name);
        public void ReadAccounts();
        public GameAccount GetAccountByName(string name);
        
    }
}