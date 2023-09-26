using System;

namespace Classes;
public class MyBank
{
    static void Main()
    {
       var account = new BankAccount("<name>", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

        account.MakeWidthdraw(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "friend paid me back");
        Console.WriteLine(account.Balance);
        BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}
    }
}