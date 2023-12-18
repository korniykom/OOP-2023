namespace MyGame
{
    public abstract class BaseAccount
    {
    public string userName{get; set;}
    public int id {get; set;}
    public int idSeed = 1;
    private int _currentRating = 1;
    public int CurrentRating
    {
        get {return _currentRating; }
        set{
            if (value < 1)
            {
                _currentRating = 1;
            }
            else 
            {
                _currentRating = value;
            }
        }
    }
    public BaseAccount(string name)
    {
        userName = name;
        id = ++idSeed;
    }
    public abstract int CalculatePoints(int bet, string outcome);
    
    }

}