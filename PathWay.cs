using System;
using System.IO;

namespace Lab2_Linq_To_XML
{
    class PathWay
    {
        private static readonly string _dataFolder = "XmlFile";
        private static readonly string _defaultPath =Path.Combine(AppContext.BaseDirectory, "..", "..");

        public static string Car => Path.Combine(_defaultPath, _dataFolder, "Cars.xml");
        public static string Driver => Path.Combine(_defaultPath, _dataFolder, "Drivers.xml");
        public static string Owner => Path.Combine(_defaultPath, _dataFolder, "Owners.xml");
        public static string Registration => Path.Combine(_defaultPath, _dataFolder, "Registration.xml");
        public static string DriverCar => Path.Combine(_defaultPath, _dataFolder, "DriverCar.xml");
        public static string CarSchema => Path.Combine(_defaultPath, _dataFolder, "Cars.xsd");
        public static string DriverSchema => Path.Combine(_defaultPath, _dataFolder, "Drivers.xsd");
        public static string OwnerSchema => Path.Combine(_defaultPath, _dataFolder, "Owners.xsd");
        public static string RegistrationSchema => Path.Combine(_defaultPath, _dataFolder, "Registration.xsd");
        public static string DriverCarSchema => Path.Combine(_defaultPath, _dataFolder, "DriverCar.xsd");

    }
}
