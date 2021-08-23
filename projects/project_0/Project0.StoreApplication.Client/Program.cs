using System;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;
using System.Collections.Generic;

namespace Project0.StoreApplication.Client
{
  class Program
  {
//8/23
// what happen  if you remove static from the below code 
//private static readonly StoreRepository _storeRepository= new StoreRepository();
//control StoreRepository.Instance to be instance
private readonly StoreRepository _storeRepository = StoreRepository.Instance;
//8/23end
    static void Main(string[] args)
    {
      //Log created by serilog 
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
      var program = new Program();

      program.CaptureOutput();
    }

    private void OutputStores()
    {

      Log.Information("mehtod outpoutstores");

      // var storeRepository = _storeRepository;
  
      foreach (var store in _storeRepository.Stores)
      {
        Console.WriteLine(store);
      }
    }

    private int CaptureInput()
    {
      Log.Information("in method captureinput");
      OutputStores();

      Console.WriteLine("pick a store base on Store Id:");

      int selected = int.Parse(Console.ReadLine()) - 1;

      return selected;
    }

    private void CaptureOutput()
    {
      var storeRepository = _storeRepository;
      // var products = new ProductRepository().Products;
      int selectedIdx = CaptureInput();
      

      Console.WriteLine("you have selected: " + " " +_storeRepository.Stores[selectedIdx] + "\n " + "Here are the products: ");

      foreach(var product in _storeRepository.Stores[selectedIdx].Products )
      {
          Console.WriteLine(product);
      }
    



    }
  }

}
