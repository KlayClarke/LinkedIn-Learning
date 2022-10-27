using System;

namespace ProgChallenge
{
  class CheckingAcct : Acct {
    private const decimal OVERDRAW_CHARGE = 35.0m;
    public CheckingAcct(string _firstname, string _lastname, decimal _balance)
    : base(_firstname, _lastname, _balance)
    {
      
    }  
    
    public override void Withdraw(decimal money)
    {
      // if account is overdrafted, apply overdraft fee
      if (money > Balance)
      {
        money += OVERDRAW_CHARGE;
      }
      base.Withdraw(money);
    }
  }
}