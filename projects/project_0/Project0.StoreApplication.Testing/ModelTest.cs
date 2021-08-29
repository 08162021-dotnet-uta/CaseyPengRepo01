using Xunit;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Storage.Adapters;
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
    [Fact]
    public void TestSerializationCustomer()
    {

      var sut = new FileAdapter().ReadFromFile<Customer>(@"/home/casey/makeacopy826/CaseyPengRepo01/projects/project_0/data/Customers.xml");
      Assert.NotEmpty(sut);


    }
    [Fact]
    public void TestSerializationStore()
    {

      var sut = new FileAdapter().ReadFromFile<Store>(@"/home/casey/makeacopy826/CaseyPengRepo01/projects/project_0/data/Stores.xml");
      Assert.NotEmpty(sut);


    }
    [Fact]
    public void TestrepoMethod()
    {
      var sut = new CustomerRepository();
      Assert.NotNull(sut);
    }

    [Fact]
    public void TestrepoSMethod()
    {
      var sut = new StoreRepository();
      Assert.NotNull(sut);
    }
  }

}