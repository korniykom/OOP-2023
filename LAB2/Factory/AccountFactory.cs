namespace MyGame
{
    public class AccountFactory
    {
        private int id = 0;
        public GameAccount MakeAccount(string type)
        {
            if(type == "premium")
            {
                return new PremiumAccount("Premium Accoutn #" + id++);
            } 
            else if (type == "regular")
            {
                return new RegularAccount("Regular Account #" + id++);
            }
            throw new ArgumentException("Enter valid type of Account");
        }
    }
}