using System;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
  class Program
  {

    static void Main(string[] args)
    {
      //Log created by serilog 
      Log.Logger = new LoggerConfiguration().CreateLogger();
      var program = new Program();

      program.CaptureOutput();
    }

    private void OutputStores()
    {

      Log.Information("mehtod outpoutstores");

      var storeRepository = new StoreRepository();

      foreach (var store in storeRepository.Stores)
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
      var storeRepository = new StoreRepository();

      Console.WriteLine("you have selected: " + " " + storeRepository.Stores[CaptureInput()]);
    }
  }
}
