using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Abstracts
{
  public abstract class CustomerAbstract{

    public string Name{get;set;}
    public override string ToString()
    {
      return "CustomerName " + Name;
    }
  }
}