
namespace Project0.StoreApplication.Domain.Models
{



  public class Product
  {

    public string Name { get; set; }
    public byte ProductId { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
      return "  ProductName:" + Name + "  ProductPrice: $" + Price;
    }

    public Product()
    {

    }
  }
}