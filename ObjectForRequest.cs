using Lab2_Linq_To_XML.Classes;
using System;
using System.Xml.Linq;

namespace Lab2_Linq_To_XML
{
    public static class ObjectForRequest
    {
        public static T ConvertTo<T>(this XElement xElement) where T : new()
        {
            var obj = new T();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var element = xElement.Element(property.Name);
                if (element == null)
                {
                    continue;
                }
                object value;
                if (property.PropertyType.IsEnum)
                {
                   value = Enum.Parse(property.PropertyType, element.Value);
                }
                else
                {
                    value = Convert.ChangeType(element.Value, property.PropertyType);
                }
                property.SetValue(obj, value);
            }

            return obj;
        }
         
    }
}
