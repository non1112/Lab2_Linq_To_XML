
using Lab2_Linq_To_XML.Enums;
using System;

namespace Lab2_Linq_To_XML.Classes
{
    [Serializable]
    public class Car
    {

        public int Id { get; set; }
        public string  Brand { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public CarBodyType BodyType { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public CarTechnicalCondition TechnicalCondition { get; set; }


        public override string ToString()
        {
            return $"Авто:{Brand} {Model} VIN {VIN}   ";
        }
    }
}
