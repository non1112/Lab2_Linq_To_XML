using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Enums;
using System;
using System.Linq;

namespace Lab2_Linq_To_XML
{
    public class ConsoleReadData : IConsoleReadData
    {
      
        public Car NewCar()
        {
            Console.Write("\tВведіть айді автомобіля : ");
            var ID = Console.ReadLine();
            int Id=Cheking.ChekingValue(ID);

            Console.Write("\tВведіть бренд автомобіля : ");
            var brand = Console.ReadLine();
            brand = Cheking.CheckString(brand);

            Console.Write("\tВведіть краЇну виробник: ");
            var manufacture = Console.ReadLine();
            manufacture = Cheking.CheckString(manufacture);

            Console.Write("\tВведіть модель автомобіля: ");
            var model = Console.ReadLine();
            model = Cheking.CheckString(model);

            Console.WriteLine("\tВведіть тип автомобіля з наведених позицій : ");
            foreach (var type in Enum.GetValues(typeof(CarBodyType)))
                Console.WriteLine($"\t{type}");
            var carType = Console.ReadLine();
            CarBodyType carBodyType=Cheking.ChekingEnumValue<CarBodyType>(carType);

            Console.Write("\tВведіть рік автомобіля: ");
            var yearstring = Console.ReadLine();
            int year = Cheking.ChekingValue(yearstring);

            Console.Write("\tВведіть серійний номер автомобіля: ");
            var vin = Console.ReadLine();
            vin = Cheking.CheckString(vin);

            Console.Write("\tВведіть колір автомобіля: ");
            var color = Console.ReadLine();
            color = Cheking.CheckString(color);

            Console.Write("\tВведіть номерний знак автомобіля: ");
            var licensePlate = Console.ReadLine();
            licensePlate = Cheking.CheckString(licensePlate);

            Console.WriteLine("Введіть технічний стан автомобіля з наведених позицій : ");
            foreach (var type in Enum.GetValues(typeof(CarTechnicalCondition)))
                Console.WriteLine($"\t{type}");
            var carTechnicalCondition = Console.ReadLine();
            CarTechnicalCondition carTechnicalType = Cheking.ChekingEnumValue<CarTechnicalCondition>(carTechnicalCondition);

            return new Car()
            {
                Id=Id,
                Brand = brand,
                Manufacturer = manufacture,
                Model = model,
                BodyType = carBodyType,
                Year = year,
                VIN = vin,
                Color = color,
                LicensePlate = licensePlate,
                TechnicalCondition = carTechnicalType

            };
           
        }

        public Driver NewDriver()
        {
            Console.Write("\tВведіть айді водія : ");
            var ID = Console.ReadLine();
            int id = Cheking.ChekingValue(ID);

            Console.WriteLine("\tВведіть данні водія");
            Console.Write("\tПризвіще : ");
            var lastName = Console.ReadLine();
            lastName=Cheking.CheckString(lastName);

            Console.Write("\tІмя : ");
            var firstName = Console.ReadLine();
            firstName = Cheking.CheckString(firstName);

            Console.Write("\tПо-батькові : ");
            var middleName = Console.ReadLine();
            middleName = Cheking.CheckString(middleName);

            Console.Write("\tВведіть номер водія : ");
            var license = Console.ReadLine();
            license = Cheking.CheckString(license);

            Console.Write("\tВедіть дата народження в флорматі - dd/mm/yyyy : ");
            var dateBirthday = Console.ReadLine();
            DateTime date = Cheking.ChekingDateTime(dateBirthday);

            Console.Write("\tВведіть місце реєстрації : ");
            string addresRegistration = Console.ReadLine();
            addresRegistration = Cheking.CheckString(addresRegistration);

            return new Driver()
            {
                Id=id,
               LastName=lastName,
               FirstName=firstName,
               MiddleName=middleName,
               DriverLicenseNumber=license,
               DateOfBirth=date,
               RegistrationAddress=addresRegistration
            };
        }

        public DriverCar NewDriverCar(ReaderXmlDocument reader)
        {
            Console.Write("\tВедіть айді обєкта : ");
            var ID = Console.ReadLine();
            int id = Cheking.ChekingValue(ID);
            
            Console.Write("\tВедіть айді машини : ");
            var car = Console.ReadLine();
            int carid = Cheking.ChekingValue(car);
            while (reader.GetCars(PathWay.Car).FirstOrDefault(b => b.Id == carid) == null)
            {
                Console.Write("\tВедіть айді машини : ");
                carid = int.Parse(Console.ReadLine());

            }

            Console.Write("\tВедіть айді водія : ");
            var driver = Console.ReadLine();
            int driverid = Cheking.ChekingValue(car);
            while (reader.GetDrivers(PathWay.Driver).FirstOrDefault(b => b.Id == driverid) == null)
            {
                Console.Write("\tВедіть айді водія : ");
                driverid = int.Parse(Console.ReadLine());

            }

            return new DriverCar() 
            {Id=id,
            CarId=carid,
            DriverId=driverid};
        }

        public Owner NewOwner()
        {
            Console.Write("\tВведіть айді водія : ");
            var ID = Console.ReadLine();
            int id = Cheking.ChekingValue(ID);

            Console.WriteLine("\tВведіть данні водія");
            Console.Write("\tПризвіще : ");
            var lastName = Console.ReadLine();
            lastName = Cheking.CheckString(lastName);

            Console.Write("\tІмя : ");
            var firstName = Console.ReadLine();
            firstName = Cheking.CheckString(firstName);

            Console.Write("\tПо-батькові : ");
            var middleName = Console.ReadLine();
            middleName = Cheking.CheckString(middleName);

            Console.Write("\tВведіть номер водія : ");
            var license = Console.ReadLine();
            license = Cheking.CheckString(license);

            Console.Write("\tВедіть дата народження в флорматі - dd/mm/yyyy : ");
            var dateBirthday = Console.ReadLine();
            DateTime date = Cheking.ChekingDateTime(dateBirthday);

            Console.Write("\tВведіть місце реєстрації : ");
            string addresRegistration = Console.ReadLine();
            addresRegistration = Cheking.CheckString(addresRegistration);

            return new Owner()
            {
                Id = id,
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                DriverLicenseNumber = license,
                DateOfBirth = date,
                RegistrationAddress = addresRegistration
            };
        }

        public Registration NewRegistration(ReaderXmlDocument reader)
        {
            Console.Write("\tВедіть айді регістрації : ");
            var ID = Console.ReadLine();
            int id = Cheking.ChekingValue(ID);

            Console.Write("\tВедіть айді машини : ");
            var stringCar = Console.ReadLine();
            int carId = Cheking.ChekingValue(stringCar);
            while (reader.GetCars(PathWay.Car).FirstOrDefault(b => b.Id == carId) == null)
            {
                Console.Write("\tАйді такого в базі данних не найдено . Ведіть айді машини : ");
                stringCar = Console.ReadLine();
                carId = Cheking.ChekingValue(stringCar);

            }

            Console.Write("\tВедіть айді власника : ");
            var stringOwner = Console.ReadLine();
            int OwnerId = Cheking.ChekingValue(stringOwner);
            while (reader.GetDrivers(PathWay.Driver).FirstOrDefault(b => b.Id == OwnerId) == null)
            {
                Console.Write("\tАйді такого в базі данних не найдено . Ведіть айді власника : ");
                stringOwner = Console.ReadLine();
                OwnerId = Cheking.ChekingValue(stringOwner);

            }

            Console.Write("\tВедіть дата регестрації в форматі - dd/mm/yyyy : ");
            var dateRegistration = Console.ReadLine();
            DateTime date = Cheking.ChekingDateTime(dateRegistration);
           

            return new Registration()
            {
                RegistrationDate = date,
                Id = id,
                CarId = carId,
                OwnerId = OwnerId
            };
        }
    }
}
