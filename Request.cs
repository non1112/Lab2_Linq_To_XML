using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2_Linq_To_XML
{
    class Request : IRequest
    {
        private IDataContent _dataContent;
        public Request(IDataContent dataContent)
        {
            _dataContent = dataContent;
        }

        public IEnumerable<Car> GetAllCar()
        {
            return from b in _dataContent.Cars.Root.Elements()
                   select b.ConvertTo<Car>();
        }

        public IEnumerable<Car> GetManufacturersNotFromCountry(string country)
        {
            return  _dataContent.Cars.Root.Elements()
                   .Select(x => x.ConvertTo<Car>())
                   .Where(x => x.Manufacturer != country).Select(x => x);
        }
        public IEnumerable<Car> GetBrandsSort()
        {
            return _dataContent.Cars.Root.Elements()
                .Select(x => x.ConvertTo<Car>())
                .OrderBy(car => car.Brand);
        }
        public int GetLatestCar()
        {
            return _dataContent.Cars.Root.Elements()
                          .Select(x => x.ConvertTo<Car>())
                          .Max(c => c.Year);             
        }
        public IEnumerable<IGrouping<CarTechnicalCondition, Car>> GroupCarTechnicalCondition()
        {
            return _dataContent.Cars.Root.Elements()
                .Select(x => x.ConvertTo<Car>())
                .GroupBy(x => x.TechnicalCondition);
        }
        public IEnumerable<Driver> GetDriverSort()
        {
            return _dataContent.Drivers.Root.Elements()
                .Select(x => x.ConvertTo<Driver>())
                .OrderBy(driver => driver.LastName)
                .ThenBy(driver => driver.FirstName)
                .ThenBy(driver => driver.MiddleName);
                
        }
        public bool CarWithBodyType(CarBodyType bodyType)
        {
           return _dataContent.Cars.Root.Elements()
                .Select(x => x.ConvertTo<Car>())
                .Any(x => x.BodyType == bodyType);
        }
        public IEnumerable<Owner> UseSkip(int index)
        {
            return _dataContent.Owners.Root.Elements()
                .Select(x => x.ConvertTo<Owner>())
                .Skip(index);
        }
        public Owner UseElementAt(int index)
        {
            return _dataContent.Owners.Root.Elements()
                .Select(x => x.ConvertTo<Owner>())
                .ElementAt(index);
        }
        public int ValueCarManufacture(string country)
        {
            return _dataContent.Cars.Root.Elements()
                .Select(x => x.ConvertTo<Car>())
                .Count(x => x.Manufacturer == country);
        }
        public IEnumerable<object> JoinDriverCar()
        {
            return from car in _dataContent.Cars.Root.Elements().Select(x => x.ConvertTo<Car>())
                   join driverCar in _dataContent.DriverCar.Root.Elements().Select(x => x.ConvertTo<DriverCar>())
                   on car.Id
                   equals driverCar.CarId into carDrivers
                   select new
                   {
                       Car = car,
                       ValueDriver = carDrivers.Count()
                   };
        }
        public string GetOldestOwner()
        {
            return _dataContent.Owners.Root.Elements()
                .Select(x => x.ConvertTo<Owner>())
                .Min(x => x.DateOfBirth)
                .ToString("dd-MM-yyyy");
        }
        public IEnumerable<Car> GetCarsAfterYears(int year)
        {
            return _dataContent.Cars.Root.Elements()
                .Select(x => x.ConvertTo<Car>())
                . Where(x => x.Year >= year);
        }
        public IEnumerable<Registration> SortRegistrationForRegDate()
        {
            return _dataContent.Registration.Root.Elements()
                .Select(x => x.ConvertTo<Registration>())
                .OrderBy(x => x.RegistrationDate);
        }
        public IEnumerable<string> GetLicenseNumber()
        {
            return _dataContent.Drivers.Root.Elements().Select(x => x.ConvertTo<Driver>())
                .Select(x => x.DriverLicenseNumber)
                .Concat(_dataContent.Owners.Root.Elements().Select(x => x.ConvertTo<Owner>()).Select(x => x.DriverLicenseNumber));
        }
       
    }
}