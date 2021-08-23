
namespace Project0.StoreApplication.Domain.Abstracts
{

  public class Product
  {
    public string ProductId { get; set; }
    public string ProductName { get; set; }

    public string ProductPrice { get; set; }
    public string StoreId { get; set; }

    public override string ToString()
    {
      return "ProductId: " + ProductId + " ProductName: " + ProductName + " ProductPrice: $" + ProductPrice + " StoreId " + StoreId;
    }
  }
}