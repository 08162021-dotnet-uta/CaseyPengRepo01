using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; set; }

    public StoreRepository()
    {
      Stores = new List<Store>()
      {
        new Store(){Name ="001", Location = "1st Ave, Uptobia"},
        new Store(){Name="002", Location = "X Street, Wonderland"},
        new Store(){Name="003", Location = "Y Boulevard, Arcadia"}
      };
    }
  }
}