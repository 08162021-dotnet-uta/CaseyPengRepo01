namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {
    public string CustomerName { get; set; }
    public string ProductName { get; set; }
    public string Total { get; set; }

    public int OrderId { get; set; }
    // public DateTime OrderDate { get; set; }

    public override string ToString()
    {
      return $"OrderId :{OrderId}    ProductName:{ProductName}     Total:$ {Total}";
    }
    public Order()
    {

    }


  }
}