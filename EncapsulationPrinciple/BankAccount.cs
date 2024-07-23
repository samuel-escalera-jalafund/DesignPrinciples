namespace EncapsulationPrinciple;

public class BankAccount
{
  public string AccountNumber { get; set; }
  
  public string Owner { get; set; }
  
  public decimal _balance { get; set; }

  public void Deposit(decimal amount)
  {
    _balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    _balance -= amount;
  }
}
