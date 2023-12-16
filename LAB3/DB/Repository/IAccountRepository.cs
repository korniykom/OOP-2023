namespace MyGame
{
    public interface IAccountRepository
    {
         Account Get(int id);
         IEnumerable<Account> GetAll();
         void Add(Account account);
         void Update(Account account, int id);
         void Remove(int id);
    }
}