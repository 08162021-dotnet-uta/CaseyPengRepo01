using System;
using System.Collections.Generic;//allows you to use List<T> Class,it is in a namespace system.collections.generic
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      var p = new Program();
      PrintAllStoreLocations();
      System.Console.WriteLine(p.SelectAStore());
    }
    static void PrintAllStoreLocations()
    {
      var StoreRepository = new StoreRepository();
      foreach (var store in StoreRepository.Stores)
      {
        System.Console.WriteLine(store);
      }

      // storeLocations.Add(new Store());
      // storeLocations.Add(new Store())
    }
    Store SelectAStore()
    {
      var sr = new StoreRepository().Stores;

      Console.WriteLine("Select a Store: ");

      var option = int.Parse(Console.ReadLine());

      var store = sr[option - 1];

      return store;
    }

  }
}
