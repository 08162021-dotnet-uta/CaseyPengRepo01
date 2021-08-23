using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository
  {
    public List<Product> Products { get; set; }
    public ProductRepository()
    {
      Products = new List<Product>()
      {
new Product {
ProductId = "1",
ProductPrice ="2",
ProductName ="Daisy",
StoreId = "1"
},
new Product {
ProductId = "1",
ProductPrice ="3",
ProductName ="Lily",
StoreId ="1"
},
      };
    }
  }

}