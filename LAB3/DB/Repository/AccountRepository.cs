namespace MyGame
{
    public class AccountRepository
    {
        public List<Account> AccountInfo;
    public AccountRepository( List<Account> accountInfo)
    {
        AccountInfo = accountInfo;
    }
    public Account Get(int id)
    {
        return AccountInfo.FirstOrDefault(d => d.id == id);
    }
    public IEnumerable<Account> GetAll() 
    {
        return AccountInfo;
    }
    public void Add(Account account)
    {
        AccountInfo.Add(account);
    }
    public void Update(Account account, int id)
    {
        var toUpdate = Get(id);
        if(toUpdate != null)
        {
            toUpdate.name = account.name;
            toUpdate.score = account.score;
        }
    }
    public void Delete(int id)
    {
        var toDelete = Get(id);
        if(toDelete != null)
        {
            AccountInfo.Remove(toDelete);
        }
    }
    }
    
}