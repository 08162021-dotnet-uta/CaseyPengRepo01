
namespace Project0.StoreApplication.Domain.Abstracts
{

  public class Product
  {
    
    public string ProductName { get; set; }

    public string ProductPrice { get; set; }
    
    public override string ToString()
    {
      return " ProductName: " + ProductName + " ProductPrice: $" + ProductPrice ;
    }
  }
}