namespace DontRepeatYourself;

public class Invoice
{
  public Order Order { get; set; }

  public decimal CalculateTotal()
  {
    decimal total = 0;
    
    foreach (var item in Order.Items)
    {
        total += item.Price * item.Quantity;
    }
    
    total -= Order.Discount;
    
    return total;
  }

  public void GenerateInvoice()
  {
    decimal total = CalculateTotal();
    Console.WriteLine($"Invoice Total: {total:C}");
  }
}
