using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{

  /// <summary>
  /// 
  /// </summary>
  public class Customer
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }


    public Customer()
    {
      Name = "First Customer";
    }
    // public void AddOrder(Product product)
    // {
    //   Orders.Add(new Order()
    //   {
    //     CustomerName = this.Name,
    //     ProductName = product.Name,
    //     Total = product.Price
    //   });
    // }

    public override string ToString()
    {
      return $"{Name} with {Orders.Count} Order so far";
    }
  }
}