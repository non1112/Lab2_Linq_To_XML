using System;
using System.Xml;
using System.Xml.Schema;

namespace Lab2_Linq_To_XML
{
    public class Validator
    {
        public static bool Validate(string xmlPath, string xsdPath)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(xmlPath);
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add(null, xsdPath);
                document.Schemas = schemaSet;
                document.Validate(ValidationEventHandler);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка валідації: " + ex.Message);
                return false;
            }
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            throw new Exception(e.Message);
        }
    }
}
