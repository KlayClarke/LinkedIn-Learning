using System;

namespace ProgChallenge
{
  public class Acct 
  {
    public string FirstName, LastName;
    public decimal Balance {get; set;}
    public Acct(string _firstname, string _lastname, decimal _balance)
    {
      FirstName = _firstname;
      LastName = _lastname;
      Balance = _balance;
    }
    // public property to get Account Owner
    public string AccountOwner {
      // returns full name of account owner
      get => $"{FirstName} {LastName}";
      
    }
    // public method to Deposit money
    public virtual void Deposit(decimal money)
    {
      // deposit money to cur balance
      Balance += money;
    }
    
    public virtual void Withdraw(decimal money)
    {
      // withdraw money from cur balance
      Balance -= money;
    }
  }
}

