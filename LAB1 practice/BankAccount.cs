using System.Runtime;
using System.Transactions;

namespace Classes;


public class BankAccount {
    
    private List<Transaction> allTransactions = new List<Transaction>();

    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
{
    get
    {
        decimal balance = 0;
        foreach (var item in allTransactions)
        {
            balance += item.Amount;
        }

        return balance;
    }
}
    private static int accountNumberSeed = 1234567890;
    //Constucture
    public BankAccount(string name, decimal initialBalance) {
        this.Owner = name;
       // this.Balance = initialBalance; 
       /*It does not fucking work*/
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
        MakeDeposit(initialBalance,DateTime.Now, "Initial balance");
    }

    public void MakeDeposit(decimal amount, DateTime date, string note) {
        if(amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");  
        }
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }
    public void MakeWidthdraw(decimal amount, DateTime date, string note) {
        if(amount <= 0 ) {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        } else if (Balance < amount) {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
        
    }
   
}
