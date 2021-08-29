using Xunit;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;
using System.Collections.Generic;

namespace Project0.StoreApplication.Testing
{
  public class ModelTest
  {
    [Fact]
    public void TestCustomer()
    {
      var sut = new Customer();
      var name = sut.Name;
      Assert.NotNull(name);
    }

    [Fact]
    public void TestStore()
    {
      var sut = new Product()
      {
        Name = "No Product",
        Price = "40"
      };
      Assert.NotNull(sut.Price);
    }

    [Fact]
    public void TestOrder()
    {
      List<Order> orders = new List<Order>();
      var sut = new Store()
      {
        Orders = orders
      };
      Assert.NotNull(sut.Orders);
    }
    [Fact]
    public void TestProduct()
    {
      var sut = new Product()
      {
        Name = "kity"
      };

      Assert.NotNull(sut.Name);
    }

  }



}