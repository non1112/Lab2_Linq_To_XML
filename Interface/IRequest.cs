using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_To_XML
{
    interface IRequest
    { 
        IEnumerable<Car> GetAllCar();
        IEnumerable<Car> GetManufacturersNotFromCountry(string country);
        IEnumerable<Car> GetBrandsSort();
        int GetLatestCar();
        IEnumerable<IGrouping<CarTechnicalCondition, Car>> GroupCarTechnicalCondition();
        IEnumerable<Driver> GetDriverSort();
        bool CarWithBodyType(CarBodyType bodyType);
        IEnumerable<Owner> UseSkip(int index);
        Owner UseElementAt(int index);
        int ValueCarManufacture(string country);
        IEnumerable<object> JoinDriverCar();
        string GetOldestOwner();
        IEnumerable<Car> GetCarsAfterYears(int year);
        IEnumerable<Registration> SortRegistrationForRegDate();
        IEnumerable<string> GetLicenseNumber();



    }
}
