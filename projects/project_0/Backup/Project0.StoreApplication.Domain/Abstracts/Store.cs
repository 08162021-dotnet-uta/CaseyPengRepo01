// using System.Collections.Generic;
// using System.Xml.Serialization;
// using Project0.StoreApplication.Domain.Models;

// namespace Project0.StoreApplication.Domain.Abstracts
// {
//   [XmlInclude(typeof(FlowerStore))]
//   // [XmlInclude(typeof(GiftStore))]
//   public abstract class noStore
//   {
//     public string StoreId { get; set; }
//     public string Location { get; set; }
//         public string StoreName { get; set; }

//     public List<Product> Products { get; set; }


//     public override string ToString()
//     {
//       return  "StoreId:" + StoreId+ " StoreName: " + StoreName  + " Location: " + Location;
//     }


//   }
// }