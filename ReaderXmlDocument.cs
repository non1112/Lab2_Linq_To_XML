using Lab2_Linq_To_XML.Classes;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab2_Linq_To_XML
{
    public class ReaderXmlDocument
    {
        public  List<Car> GetCars(string fileName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            var result = new List<Car>();
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
               var car=new Car()
               {
                   Id = int.Parse(node.Attributes["Id"].InnerText),
                   Brand = node["Brand"].InnerText,
                   Model = node["Model"].InnerText,
                   Manufacturer = node["Manufacturer"].InnerText,
                   BodyType = ParserEnum.BodyType(node["BodyType"].InnerText),
                   Year = int.Parse(node["Year"].InnerText),
                   VIN = node["VIN"].InnerText,
                   Color = node["Color"].InnerText,
                   LicensePlate = node["LicensePlate"].InnerText,
                   TechnicalCondition = ParserEnum.TechnicalCondition(node["TechnicalCondition"].InnerText)
               } ;
               result.Add(car);
            }
            return result;
        }
        public  List<Owner> GetOwners(string fileName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            var result = new List<Owner>();
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                result.Add(new Owner()
                {
                    Id = int.Parse(node.Attributes["Id"].InnerText),
                    LastName= node["LastName"]?.InnerText,
                    FirstName= node["FirstName"]?.InnerText,
                    MiddleName= node["MiddleName"]?.InnerText,
                    DriverLicenseNumber= node["DriverLicenseNumber"]?.InnerText,
                    RegistrationAddress= node["RegistrationAddress"]?.InnerText,
                    DateOfBirth=DateTime.Parse(node["DateOfBirth"]?.InnerText)
                });
            }

            return result;
        }
        public  List<Driver> GetDrivers(string fileName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            var result = new List<Driver>();
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                result.Add(new Driver()
                {
                    Id = int.Parse(node.Attributes["Id"].InnerText),
                    LastName = node["LastName"]?.InnerText,
                    FirstName = node["FirstName"]?.InnerText,
                    MiddleName = node["MiddleName"]?.InnerText,
                    DriverLicenseNumber = node["DriverLicenseNumber"]?.InnerText,
                    RegistrationAddress = node["RegistrationAddress"]?.InnerText,
                    DateOfBirth = DateTime.Parse(node["DateOfBirth"]?.InnerText)
                });
            }

            return result;
        }
        public List<DriverCar> GetDriverCar(string fileName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            var result = new List<DriverCar>();
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                result.Add(new DriverCar()
                {
                    Id = int.Parse(node.Attributes["Id"].InnerText),
                    CarId = int.Parse(node["CarId"].InnerText),
                    DriverId = int.Parse(node["DriverId"].InnerText)
                });
            }

            return result;
        }
        public List<Registration> GetRegistartion(string fileName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            var result = new List<Registration>();
            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                result.Add(new Registration()
                {
                    Id = int.Parse(node.Attributes["Id"].InnerText),
                    CarId = int.Parse(node["CarId"].InnerText),
                    OwnerId = int.Parse(node["OwnerId"].InnerText),
                    RegistrationDate=DateTime.Parse(node["RegistrationDate"].InnerText)
                });
            }

            return result;
        }

    }
}
