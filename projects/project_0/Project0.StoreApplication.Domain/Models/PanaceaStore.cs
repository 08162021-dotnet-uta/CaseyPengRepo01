using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class PanaceaStore : Store
  {
    public PanaceaStore()
    {
      Name = "Panacea Store";
      Location = "X Ave, Uptobia";
      Products = new List<Product>(){
        new Product(){
          Name ="万灵药",
          Price = "50"
        }
      };



    }
  }
}