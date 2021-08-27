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
// // var store = _storeSingleton.Stores[CaptureInput<Customer>(_storeSingleton.Stores)];
// private const string _logFilePath = @"/home/casey/exercise/CaseyPengRepo01/data/logs.txt";

// /// <summary>
// /// Define the Main Method 
// /// </summary>
// /// <param name="args"></param>
//    private static void Main(string[] args)
//     {
//       //Log created by serilog 
//          Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();
//       // var program = new Program();
// Run();
//       // program.CaptureOutput();
//     }
//     private static void Run()
//     {
//    Log.Information("method: Run()")

//    if(_customerSingleton.Customer.Count ==0)
//    {

//    }
//       CaptureOutput();
//     }

//     // private void OutputStores()
//     // {

//     //   Log.Information("mehtod outpoutstores");

//     //   // var storeRepository = _storeRepository;
  
//     //   foreach (var store in _storeRepository.Stores)
//     //   {
//     //     Console.WriteLine(store);
//     //   }
//     // }
//   private void Output<T>(List<T> data) where T : class
//     {//or output < {typeof(T}>)}

//       Log.Information($"mehtod: Output<{typeof(T)}>()"); //string interpolation
//       Output<Store>(_storeSingleton.Stores);
//        Output<Store>(_storeSingleton.Stores);


//       // var storeRepository = _storeRepository;
  
//       foreach (var item in data)
//       {
//         Console.WriteLine(item);
//       }
//     }
//     private static int CaptureInput()
//     {
//       Log.Information("in method captureinput");
//       Output<Store>(_storeRepository.Stores);

//       Console.WriteLine("pick a store base on Store Id:");

//       int selected = int.Parse(Console.ReadLine()) - 1;

//       return selected;
//     }
//     //    private static int CaptureInput()
//     // {
//     //   Log.Information("in method captureinput");
//     //   OutputStores();

//     //   Console.WriteLine("pick a store base on Store Id:");

//     //   int selected = int.Parse(Console.ReadLine()) - 1;

//     //   return selected;
//     // }


//     private static void CaptureOutput()
//     {
//       var storeRepository = _storeRepository;
//       // var products = new ProductRepository().Products;
//       int selectedIdx = CaptureInput();
      
//    var selectedStore = _storeRepository.Stores[selectedIdx];
//       Console.WriteLine("you have selected: " + " " + selectedStore.StoreName + "\n " + "Here are the products: ");

//       foreach(var product in selectedStore.Products )
//       {
//           Console.WriteLine(product);
//       }

// Console.WriteLine("pick a product yout want to purchase base on Id:");

//       int selectedProductIdx = int.Parse(Console.ReadLine()) - 1;
//       var selectedProduct = selectedStore.Products[selectedProductIdx];
      
//         Console.WriteLine("you selected "+ selectedProduct.ProductName  + ", and your total is $" + selectedProduct.ProductPrice );
     

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
    private const string _logFilePath = @"/home/casey/excercise/CaseyPengRepo01/data/logs.txt";

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

      Console.WriteLine("Are you a customer or a store ? 1 for custormer,  for store");
       int input = int.Parse(Console.ReadLine());
       if(input == 2){

           if (_customerSingleton.Customers.Count == 0)
      {
        _customerSingleton.Add(new Customer());
      }

      // var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      // var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
      // // stores
      //Output<Store>(_storeSingleton.Stores);
      // products
      //Output<Product>(_productSingleton.Products);

      Console.WriteLine("customer");
       }else if(input == 1){
if(_storeSingleton.Stores.Count == 0)
{
  _storeSingleton.Add(new Store());
}
// var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];

// Console.WriteLine(store);
var stores = _storeSingleton.Stores;
foreach(var store in stores)
{
Console.WriteLine(store);
}

    }
    }
    /// <summary>
    /// 
    /// </summary>
    // private static void Output<T>(List<T> data) where T : class
    // {
    //   Log.Information($"method: Output<{typeof(T)}>()");

    //   // var index = 0;

    //   foreach (var item in data)
    //   {
    //     Console.WriteLine($" {item}");
    //   }
    // }
  

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    // private static int Capture<T>(List<T> data) where T : class
    // {
    //   Log.Information("method: Capture()");

    //   Output<T>(data);
    //   Console.Write("make selection: ");

    //   int selected = int.Parse(Console.ReadLine()) -1;

    //   return selected ;
    // }
  }
}

