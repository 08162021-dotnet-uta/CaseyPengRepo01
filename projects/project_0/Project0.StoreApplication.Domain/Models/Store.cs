using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
namespace Project0.StoreApplication.Domain.Models
{
  public class Store
  {
    public string StoreId{get;set;}
    public string StoreName{get;set;}
    public List<Product> Products{get;set;}
    public Store()
    {

    {  StoreId = "1";
      StoreName = "Flower Store";
      Products = new List<Product>()
      {
new Product {
ProductName ="Daisy",
ProductPrice ="2",
ProductId= "1"

}};
   {  StoreId = "2";
      StoreName = "Gift Store";
      Products = new List<Product>()
      {
new Product {
ProductName ="Greeting Card",
ProductPrice ="2",
ProductId= "1"

},
new Product {
ProductName ="Music Box",
ProductPrice ="300",
ProductId = "2"


}
};
      
      
      };


      
    }}
    public override string ToString()
    {
       return  "StoreId:" + StoreId+ " StoreName: " + StoreName + Products;
    }

  }
  
}