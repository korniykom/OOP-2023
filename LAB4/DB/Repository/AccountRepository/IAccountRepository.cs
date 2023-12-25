namespace MyGame
{
    public interface IAccountRepository
    {
        IEnumerable<GameAccount> GetAllPlayers();
        GameAccount GetById(int id);
        GameAccount Create(string type, string name);
        GameAccount GetAccountByName(string name);
    }
}