using System;

namespace ProgChallenge
{
  class SavingsAcct : Acct {
    decimal Interest {get; set;}
    int NumOfWithdraws {get; set;}
    private const decimal EXCESS_CHARGE = 2.0m;
    public SavingsAcct(string _firstname, string _lastname, decimal _interest, decimal _balance)
    : base(_firstname, _lastname, _balance)
    {
      Interest = _interest;
    }
    
    // public method to Apply Interest to Balance on SavingsAcct
    public void ApplyInterest()
    { 
      // apply interest rate to cur balance
      Balance *= (1 + Interest);
    }
    
    public override void Withdraw(decimal money)
    {
      // prevent overdraft
      if (money > Balance)
      {
        Console.WriteLine("Attempt to overdraw - denied");
      }
      else
      {
        NumOfWithdraws++;
        if (NumOfWithdraws > 3)
        {
          money += EXCESS_CHARGE;
          Console.WriteLine("More than 3 savings withdrawals - You've been charged 2 dollars");
        }
        base.Withdraw(money);
      }
    }
  }
}