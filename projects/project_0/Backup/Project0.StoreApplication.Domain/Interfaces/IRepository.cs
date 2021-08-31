using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces
{
  //c# all interfaces name start with I 
  public interface IRepository<T> where T : class 
  {
bool Insert(T entry);
T Update();
List<T> Select();
bool Delete();
  }
}