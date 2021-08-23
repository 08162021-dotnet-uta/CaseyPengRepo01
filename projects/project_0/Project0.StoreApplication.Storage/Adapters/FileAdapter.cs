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