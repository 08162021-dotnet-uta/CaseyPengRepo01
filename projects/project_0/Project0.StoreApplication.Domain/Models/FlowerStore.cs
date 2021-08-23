using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
namespace Project0.StoreApplication.Domain.Models
{
  public class FlowerStore : Store
  {
    public FlowerStore()
    {
      StoreId = "1";
      StoreName ="Flower Store";
      Location = "x Ave, Uptobia";
     Products = new List<Product>()
      {
new Product {
ProductName ="Daisy",
ProductPrice ="2"

},
new Product {
ProductName ="Lily",
ProductPrice ="3"


},
    };
  }
}
}