using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Storage;
using Project0.StoreApplication.Domain.Models;
using Serilog;

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
      Console.WriteLine("get all the customers");

      HelloSQL();
      Console.WriteLine("Are you a customer or a store ? c for custormer,  s for store");
      System.Environment.Exit(0);
      string selected = Console.ReadLine().ToLower();
      if (selected == "s")
      {

        if (_storeSingleton.Stores.Count == 0)
        {
          _storeSingleton.Add(new Store());
        }

        var stores = _storeSingleton.Stores;


        Console.WriteLine("Which Store are you:");
        Output<Store>(stores);

        var storeYouPicked = stores[Selected() - 1];
        // var productsInStore = 
        Console.WriteLine($" Here are the past sales:  ");
        foreach (var order in storeYouPicked.Orders)
        {
          Console.WriteLine(order);
        }


      }
      else if (selected == "c")
      {

        if (_customerSingleton.Customers.Count == 0)
        {
          _customerSingleton.Add(new Customer());
        }
        Console.WriteLine("Enter your name to retrive info :");
        string customerName = Console.ReadLine().ToLower();


        foreach (var customer in _customerSingleton.Customers)
        {
          if (customer.Name.ToLower() != customerName)
          {

            Console.WriteLine("Invalid Name");
            System.Environment.Exit(0);

          }
        }



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
          Console.WriteLine("Selected a product to purchase:   ");
          var selectedProduct = selectedStore.Products[Selected() - 1];
          var customer = _customerSingleton.Customers[0];
          var customers = _customerSingleton.Customers;
          Console.WriteLine($"you selected : {selectedProduct} and \n the total is $ {selectedProduct.Price}.  \n Do you want to check out (Y)? C for canceling the order. Y/C");
          string outcome = Console.ReadLine().ToLower();

          if (outcome == "y")
          {

            Console.WriteLine("You made a purchase!");
          }
          else if (outcome == "c")
          {
            Console.WriteLine("Your Purchase is canceled.");

            System.Environment.Exit(0);
          }


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
      Log.Information("method: Selected()");
      int option = int.Parse(Console.ReadLine());
      return option;
    }
    private static int Capture<T>(List<T> data) where T : class
    {//return an index
      Log.Information("method: Capture()");


      Console.Write("make a selection: ");

      int selected = int.Parse(Console.ReadLine()) - 1;

      return selected;
    }



    private static void HelloSQL()
    {
      var def = new DemoEF();

      def.SetCustomer(new Customer(){
        Name =" hello World"
      });

      foreach (var item in def.GetCustomers())
      {
        Console.WriteLine(item.Name);
      }
    }

  }
}