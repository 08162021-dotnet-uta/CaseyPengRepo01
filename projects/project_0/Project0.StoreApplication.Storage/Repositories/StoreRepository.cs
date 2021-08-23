using System.Collections.Generic;//allows you to use List<T> Class,it is in a namespace system.collections.generic
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {

//    //8/23 start  //define a path for where we save our stores

private const string _path =  @"/home/casey/exercise/CaseyPengRepo01/data/stores.xml";

     // 8/23end 
    public List<Store> Stores { get; set; }

    public StoreRepository()
    {
      // var fileAdapter = new FileAdapter();
      // var fileAdapter = new FileAdapter();
      // if(fileAdapter.ReadFromFile<List<Store>>(_path)==null)
      // {
        //fileAdapter.Wreit to File<List<Store>>
         Stores = new List<Store>()
      {
        new FlowerStore(),
        new GiftStore()
      };
      // }
     
      // //8/23 start 
      // Stores = fileAdapter.ReadFromFile<List<Store>>(_path);
       
    }
private  static StoreRepository _storeRepository;
// public static StoreRepository GetInstance()
// {
// if (_storeRepository == null){
//   _storeRepository = new StoreRepository();
// }
// return _storeRepository;
// }
public static StoreRepository Instance
{
  get{
  if(_storeRepository==null)
  {
    _storeRepository = new StoreRepository();
  }
return _storeRepository;
  }
}

// // 8/23end
 }
}