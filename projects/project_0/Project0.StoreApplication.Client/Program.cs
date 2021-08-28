using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

// namespace Project0.StoreApplication.Client
// {
// /// <summary>
// /// define the program class 
// /// </summary>

//   internal class Program
//   {
// //8/23
// // what happen  if you remove static from the below code 
// //private static readonly StoreRepository _storeRepository= new StoreRepository();
// //control StoreRepository.Instance to be instance

// private static readonly StoreSingleton _storeRepository = StoreRepository.Instance;
// //8/23end
// private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
// //TRY SINGLETON

//     }

//    public void Add(Customer customer )
//    {

//    }
//   }

// }
namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Defines the Program Class
  /// </summary>
  internal class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private const string _logFilePath = @"/home/casey/makeacopy826/CaseyPengRepo01/projects/project_0/data/logs.txt";

    /// <summary>
    /// Defines the Main Method
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Run();
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Run()
    {
      Log.Information("method: Run()");

      Console.WriteLine("Are you a customer or a store ? 1 for custormer,  2 for store");
      int selected = Selected();
      if (selected == 2)
      {

        if (_storeSingleton.Stores.Count == 0)
        {
          _storeSingleton.Add(new Store());
        }

        var stores = _storeSingleton.Stores;
        Console.WriteLine("Here are the orders: ");
        foreach (var store in stores)
        {
          foreach (var order in store.Orders)
          {
            Console.WriteLine(order);
          }
        }

      }
      else if (selected == 1)
      {

        if (_customerSingleton.Customers.Count == 0)
        {
          _customerSingleton.Add(new Customer());
        }
        // Console.WriteLine("Enter your name to retrive info :");
        // string customerName = Console.ReadLine().ToLower();
        // List<Customer> currentCustomer = new List<Customer>();
        // foreach (var customer in _customerSingleton.Customers)
        // {
        //   if (customer.Name.ToLower() == customerName)
        //   {
        //     currentCustomer.Add(customer);
        //     Console.WriteLine($"{customer} + {currentCustomer[0]}");
        //   }
        // }


        // var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
        Console.WriteLine("Do you want to see 1)List of Stores ? 2)Order History");
        int choice = Selected();
        if (choice == 1)
        {
          if (_storeSingleton.Stores.Count == 0)
          {
            Console.WriteLine("No Store");
          }
          var stores = _storeSingleton.Stores;
          Console.WriteLine("Here are the stores: ");
          Output<Store>(stores);
          var selectedStore = stores[Capture<Store>(stores)];
          Console.WriteLine($"You selected store: {selectedStore.Name} with products :");
          Output<Product>(selectedStore.Products);
          Console.WriteLine("Selected a poduct to purchase: ");
          var selectedProduct = selectedStore.Products[Selected() - 1];
          Console.WriteLine($"you selected : {selectedProduct} and \n the total is $ {selectedProduct.Price}.  \n Do you want to check out?  Y/N");
          if (Console.ReadLine().ToLower() == "y")
          {
            // customer.AddOrder(selectedProduct);
            // Console.WriteLine(customer.Orders[0]);
          }
;
          // foreach (var store in stores)
          // {
          //   string storeName = store.Name.ToLower();
          //   // if (storeName.Contains(selectedStore))
          //   // {
          //   //   Console.WriteLine($"Store selected :{store}");
          //   //   foreach (var product in store.Products)
          //   //   {
          //   //     Console.WriteLine(product);
          //   //   }
          //   //   Console.WriteLine("Select a product to pucrchase");
          //   //   var selectedProduct = Console.ReadLine().ToLower();
          //   //   //Output<Product>(store.Products);
          //   // }
          //   // else
          //   // {
          //   //   Console.WriteLine("fail");
          //   // }
          // }

        }
        else if (choice == 2)
        {
          var customers = _customerSingleton.Customers;
          foreach (var customer in customers)
          {
            foreach (var order in customer.Orders)
            {
              Console.WriteLine(order);
            }
          }
        }


        //--don't delet the below line, keep for reference
        // var store = _storeSingleton.Stores[0];
        // Console.WriteLine(store.Products[0]);


      }
    }



    /// 
    //
    /// <summary>
    /// use constraints to restrict client code to specify certain types while instantiating generic types
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// 
    //Class Contraint: ONLY REFERENCE Type can be passed as argument
    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"method: Output<{typeof(T)}>()");

      int idex = 1;

      foreach (var item in data)
      {
        Console.WriteLine($" {idex}   {item}");
        idex++;
      }
    }



    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>




    private static int Selected()
    {
      int option = int.Parse(Console.ReadLine());
      return option;
    }
    private static int Capture<T>(List<T> data) where T : class
    {//return an index
      Log.Information("method: Capture()");


      Console.Write("make selection: ");

      int selected = int.Parse(Console.ReadLine()) - 1;

      return selected;
    }
  }

}