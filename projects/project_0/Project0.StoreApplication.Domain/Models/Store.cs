using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace Project0.StoreApplication.Domain.Models
{
  [XmlInclude(typeof(PanaceaStore))]
  public class Store
  {
    public int StoreId { get; set; }
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
    public void AddOrder(string name, string total)
    {
      this.Orders.Add(new Order()
      {
        ProductName = name,
        Total = total
      });
    }

  }

}
