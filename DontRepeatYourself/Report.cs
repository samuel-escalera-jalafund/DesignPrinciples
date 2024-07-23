namespace DontRepeatYourself;

public class Report
{
  public List<Order> Orders { get; set; } = [];

  public void GenerateReport()
  {
    foreach (var order in Orders)
    {
      decimal total = 0;
      
      foreach (var item in order.Items)
      {
        total += item.Price * item.Quantity;
      }
      
      total -= order.Discount;
      
      Console.WriteLine($"Order Total: {total:C}");
    }
  }
}
