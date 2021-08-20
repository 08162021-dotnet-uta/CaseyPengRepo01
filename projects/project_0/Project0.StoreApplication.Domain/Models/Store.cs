namespace Project0.StoreApplication.Domain.Models
{
  public class Store
  {
    public string Name { get; set; }
    //make sure that all the output looks the same in 
    public string Location {get; set;}
    public override string ToString()
    {
      return Name + " -" + Location;

    }
   
  }
}