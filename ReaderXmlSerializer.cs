using Lab2_Linq_To_XML.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab2_Linq_To_XML
{
   public class ReaderXmlSerializer
    {
        public List<T> GetList<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(typeof(T).Name + "s"));
            List<T> myObjects = new List<T>();
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                myObjects = (List<T>)serializer.Deserialize(fileStream);
            }
            return myObjects;
        }
    }
}
