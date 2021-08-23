using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using System.Xml.Serialization;
using System.IO;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public List<Store> ReadFromFile()
    {
      // file path
      var path = @"/home/casey/exercise/CaseyPengRepo01/data/project_0.xml";
      // open file
      var file = new StreamReader(path);
      // serialize object
      var xml = new XmlSerializer(typeof(List<Store>));
      // read from file
      var stores = xml.Deserialize(file) as List<Store>;
      // return data
      return stores;
    }


    //8/23 read file in respect of type, Generic way of reading
    //pass in the path rather than us coming up with the path
    //generic : also some constrain  only support weent the type is a lass , can be any ref type you want, not just class !
    //or where F: class, new () we want the class to only containt the empty constructor,

    // public F ReadFromFile<F>(string path) where F : class
    // {  // file path
    //   // var path = @"/home/casey/exercise/CaseyPengRepo01/data/project_0.xml";
    //   // open file
    //   var file = new StreamReader(path);
    //   // serialize object
    //   var xml = new XmlSerializer(typeof(F));
    //   // read from file
    //   var result = xml.Deserialize(file) as List<F>;
    //   // return data
    //   return result;

    // }
    // public void UseReadFile()
    // {
    //   ReadFromFile<Store>("path:where you want to save ");
    // }
    //end of 8/23 

    public void WriteToFile(List<Store> stores)
    {
      //file path
      string path = @"/home/casey/exercise/CaseyPengRepo01/data/project_0.xml";
      //open file
      var file = new StreamWriter(path);
      //serilize obj
      var xml = new XmlSerializer(typeof(List<Store>));
      //write to file 
      xml.Serialize(file, stores);
      //close file 
      file.Close();
    }
  }
}