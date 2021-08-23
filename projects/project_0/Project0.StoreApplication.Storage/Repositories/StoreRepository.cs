using System.Collections.Generic;//allows you to use List<T> Class,it is in a namespace system.collections.generic
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; set; }

    public StoreRepository()
    {
      // var fileAdapter = new FileAdapter();
      // var fileAdapter = new FileAdapter();
      Stores = new List<Store>()
      {
        new FlowerStore(),
        new GiftStore()
      };
      // Stores = fileAdapter.ReadFromFile();
    }

  }
}