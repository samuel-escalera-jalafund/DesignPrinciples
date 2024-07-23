namespace DontRepeatYourself;

public class Order
{
  public List<OrderItem> Items { get; set; } = [];

  public decimal Discount { get; set; }

  public decimal CalculateTotal()
  {
    decimal total = 0;

    foreach (var item in Items)
    {
      total += item.Price * item.Quantity;
    }

    total -= Discount;

    return total;
  }
}
