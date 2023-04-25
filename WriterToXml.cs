using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab2_Linq_To_XML
{
    public class WriterToXml
    {
        public void Writer<T>(string path, IEnumerable<T> list)
        {
            var settings = new XmlWriterSettings()
            { 
                Indent = true 
            };

            using (var xmlWriter = XmlWriter.Create(path, settings))
            {

                xmlWriter.WriteStartElement(typeof(T).Name + "s");

                foreach (var item in list)
                {
                    xmlWriter.WriteStartElement(typeof(T).Name);

                    foreach (var property in typeof(T).GetProperties())
                    {
                        
                        if (property.Name == "DateOfBirth" || property.Name == "RegistrationDate")
                        {
                           
                            xmlWriter.WriteElementString(property.Name, ((DateTime)property.GetValue(item)).ToString("yyyy-MM-ddTHH:mm:ss"));
                        }
                        else { xmlWriter.WriteElementString(property.Name, property.GetValue(item).ToString()); }
                        
                    }

                     xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
        }
       
    }
}