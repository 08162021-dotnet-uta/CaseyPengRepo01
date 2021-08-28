using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
//referenc to all the available stres
namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreSingleton
  {
    private static StoreSingleton _StoreSingleton;
    private static readonly StoreRepository _StoreRepository = new StoreRepository();

    //define a store based on the store defined in Model.CS
    //// private List<Store> _stores;
    // public List<Store> GetStores()
    // {
    //   return Stores;
    // }

    //     public void setStore(List<Store> stores)
    //     {
    // _stores = stores;
    //     }
    public List<Store> Stores { get; private set; }
    public static StoreSingleton Instance

    {
      get
      {
        //check if a Store floder already exits in our data base, if not create one
        if (_StoreSingleton == null)
        {
          _StoreSingleton = new StoreSingleton();
        }

        return _StoreSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      Stores = _StoreRepository.Select();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Store"></param>
    public void Add(Store Store)
    {
      _StoreRepository.Insert(Store);
      Stores = _StoreRepository.Select();
    }
  }
}