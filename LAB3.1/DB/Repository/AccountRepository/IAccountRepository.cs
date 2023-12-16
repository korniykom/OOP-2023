namespace MyGame
{
    public interface IAccountRepository
    {
        IEnumerable<GameAccount> GetAllPlayers();
        GameAccount GetById(int id);
        GameAccount Create(string type, string name);
        void UpdateName(int id, string name);
    }
}