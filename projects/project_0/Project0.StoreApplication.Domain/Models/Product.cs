
namespace Project0.StoreApplication.Domain.Models
{



  public class Product
  {

    public string Name { get; set; }

    public string Price { get; set; }

    public override string ToString()
    {
      return "  ProductName:" + Name + "  ProductPrice: $" + Price;
    }

    public Product()
    {

    }
  }
}