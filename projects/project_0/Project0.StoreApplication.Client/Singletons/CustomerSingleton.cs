using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;
namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomerSingleton
  {
    private static CustomerSingleton _customerSingleton;
    private static readonly CustomerRepository _customerRepository = new CustomerRepository();

    //get customers 
    public List<Customer> Customers { get; private set; }

    public static CustomerSingleton Instance
    {
      get
      {
        //check if a customer floder already exits in our data base, if not create one
        if (_customerSingleton == null)
        {
          _customerSingleton = new CustomerSingleton();
        }

        return _customerSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private CustomerSingleton()
    {
      Log.Information("Constructor: CustomerSingleton()");
      Customers = _customerRepository.Select();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="customer"></param>
    /// 
    /// customer MODEL defines Customer
    public void Add(Customer customer)
    {
      Log.Information("Method: Add(Customer)");
      _customerRepository.Insert(customer);
      Customers = _customerRepository.Select();
    }
    // public void AddOder(List<Customer> customers)
    // {


    // }

  }
}