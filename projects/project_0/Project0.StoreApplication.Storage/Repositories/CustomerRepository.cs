using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class CustomerRepository : IRepository<Customer>
  {
private const string _path = @"/home/casey/exercise/CaseyPengRepo01/data/customers.xml";
private static readonly FileAdapter _fileAdapter = new FileAdapter();

public CustomerRepository()
{
  // make sure the file exits 
  if(_fileAdapter.ReadFromFile<Customer>(_path) ==null)
  {
    _fileAdapter.WriteToFile<Customer>(_path, new List<Customer>());
  }
}

public bool Delete()
{
  throw new System.NotImplementedException();
}

public bool Insert(Customer entry)
{
  _fileAdapter.WriteToFile<Customer>(_path, new List<Customer>{entry});
  return true;
}
public List<Customer> Select()
{
return _fileAdapter.ReadFromFile<Customer>(_path);
}

public Customer Update()
{
  throw new System.NotImplementedException();
}
  }
}

