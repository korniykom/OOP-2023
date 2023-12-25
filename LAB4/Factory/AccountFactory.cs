namespace MyGame
{
    public class AccountFactory
    {
        public GameAccount MakeAccount(string type, string name)
        {
            if(type == "premium")
            {
                return new PremiumAccount(name);
            } 
            else if (type == "regular")
            {
                return new RegularAccount(name);
            }
            throw new ArgumentException("Enter valid type of Account");
        }
    }
}