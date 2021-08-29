using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
namespace Project0.StoreApplication.Domain.Models
{
  public class Store
  {

    public string Name { get; set; }
    public string Location { get; set; }
    public List<Product> Products = new List<Product>();

    public List<Order> Orders = new List<Order>();
    // public string Location{get;set;}
    public override string ToString()
    {
      return " StoreName: " + Name + " Location: " + Location;
      //  + "products "+ Products;
    }
    public Store()
    {

    }

  }

}
