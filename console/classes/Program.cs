using System;
using System.Collections.Generic;

namespace classes
{
  public class BankAccount {
    /*
    <summary>
    <c>MakeDeposit</c> makes a deposit

    </summary>
    */
    private static int accountNumberSeed = 1234567890;
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance {
      get {
        decimal balance = 0;
        foreach (var item in allTransactions) {
          balance += item.Amount;
        }
        return balance;
      }

    }

    private List<Transaction> allTransactions = new List<Transaction>();

    public BankAccount(string name, decimal initialBalance) {
      // Initialisation method
      this.Owner = name;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;
      MakeDeposit(initialBalance, DateTime.Now, "initial balance");

    }
    public void MakeDeposit(
      decimal amount,
      DateTime date,
      string note
    ) {
      if(amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount),
        "Amount of deposit must be positive");
      }
      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(
      decimal amount,
      DateTime date,
      string note
    ) {
      if(amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount),
        "Amount of withdrawal must be positive");
      }
      if(Balance - amount < 0) {
        throw new InvalidOperationException("Insufficient funds.");
      }
      var withdrawal = new Transaction(-amount,date,note);

      allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory() {
      var report = new System.Text.StringBuilder();

      decimal balance = 0;
      report.AppendLine("Date\tAmount\tBalance\tNote");
      foreach (var item in allTransactions) {
        balance += item.Amount;
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
      }
      return report.ToString();
    }
  }
  class Program {
    static void Main(string[] args) {
      var account = new BankAccount("Bruce", 1000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial funds.");

      account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
      Console.WriteLine(account.Balance);
      account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
      Console.WriteLine(account.Balance);

      Console.WriteLine(account.GetAccountHistory());
    }
  }
}
