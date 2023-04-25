using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Enums;
using System;

namespace Lab2_Linq_To_XML
{
    class DataOutput : IDataOutput
    {
        private IRequest _request;
        
        public DataOutput(IRequest request)
        {
            _request = request;
        }

        public void ShowAll()
        {
            ReaderXmlDocument xmlDocumentReader = new ReaderXmlDocument();

            ReaderXmlSerializer xmlSerializerReader = new ReaderXmlSerializer();
            Console.WriteLine("Десеріалізувати за допомогою XmlDocument - 1 або XmlSerializer - 2  ");
            var choice = Console.ReadLine();
            int ch = Cheking.ChekingValue(choice);
            switch (ch)
            {
                case 1:
                    var cars = xmlDocumentReader.GetCars(PathWay.Car);
                    ShowList.ShowFile<Car>(cars);

                    var drivers = xmlDocumentReader.GetDrivers(PathWay.Driver);
                    ShowList.ShowFile<Driver>(drivers);

                    var owners = xmlDocumentReader.GetOwners(PathWay.Owner);
                    ShowList.ShowFile<Owner>(owners);

                    var registration = xmlDocumentReader.GetRegistartion(PathWay.Registration);
                    ShowList.ShowFile<Registration>(registration);

                    var driverCar = xmlDocumentReader.GetDriverCar(PathWay.DriverCar);
                    ShowList.ShowFile<DriverCar>(driverCar);
                    break;
                case 2:
                    var car = xmlSerializerReader.GetList<Car>(PathWay.Car);
                    ShowList.ShowFile<Car>(car);

                    var driver = xmlSerializerReader.GetList<Driver>(PathWay.Driver);
                    ShowList.ShowFile<Driver>(driver);

                    var owner = xmlSerializerReader.GetList<Owner>(PathWay.Owner);
                    ShowList.ShowFile<Owner>(owner);

                    var drivercar = xmlSerializerReader.GetList<DriverCar>(PathWay.DriverCar);
                    ShowList.ShowFile<DriverCar>(drivercar);

                    var registrations = xmlSerializerReader.GetList<Registration>(PathWay.Registration);
                    ShowList.ShowFile<Registration>(registrations);

                    break;
            }

        }
        public void CreateXmlFile()
        {
            WriterToXml xxx = new WriterToXml();
           
                Console.WriteLine("Який клас-файл ви хочете створити?");
                Console.WriteLine("\t 1)Car ");
                Console.WriteLine("\t 2)Driver ");
                Console.WriteLine("\t 3)Owner ");
                Console.WriteLine("\t 4)DriverCar ");
                Console.WriteLine("\t 5)Registration ");
                string choice = Console.ReadLine();
                int choicee= Cheking.ChekingValue(choice);
                switch (choicee) 
                {
                    case 1:
                        var car = RunnerForConsoleDate.ListValue<Car>();
                        if (car.Count != 0)
                        {
                            xxx.Writer(PathWay.Car, car);
                        }
                      
                        break;
                    case 2:
                        var driver = RunnerForConsoleDate.ListValue<Driver>();
                        if (driver.Count != 0)
                        {
                            xxx.Writer(PathWay.Driver, driver);
                        }
                       
                        break;
                    case 3:
                        var owner = RunnerForConsoleDate.ListValue<Owner>();
                        if (owner.Count != 0)
                        {
                            xxx.Writer(PathWay.Owner, owner);
                        }
                       
                        break;
                    case 4:
                        var driverCar = RunnerForConsoleDate.ListValue<DriverCar>();
                        if (driverCar.Count != 0)
                        {
                            xxx.Writer(PathWay.DriverCar, driverCar);
                        }
                       
                        break;
                    case 5:
                        var registration = RunnerForConsoleDate.ListValue<Registration>();
                        if (registration.Count != 0)
                        {
                            xxx.Writer(PathWay.Registration, registration);
                        }
                        break;
                }
          

        }

        public void GetAllCar()
        {
            var cars = _request.GetAllCar();
            Console.WriteLine("\tВивести вміст всіх машин");
            foreach (var item in cars)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
        public void GetManufacturersNotFromCountry()
        {
            string country = "Germany";
            var cars = _request.GetManufacturersNotFromCountry(country);
            Console.WriteLine($"\tВивести всі машини , які виготовлені не в {country}");
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Brand} {item.Model} - {item.Manufacturer}");
            }
        }
        public void GetBrandsSort()
        {
            var cars = _request.GetBrandsSort();
            Console.WriteLine($"\tСортування. Відсортувати мишини за маркою");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
        public void GetLatestCar()
        {
            Console.WriteLine($"\tОтримати найновіший автомобіль.");
            var cars = _request.GetLatestCar();
          
          Console.WriteLine(cars);
           
        }
        public void GroupCarTechnicalCondition()
        {
            var car = _request.GroupCarTechnicalCondition();
            Console.WriteLine($"\tВикористання Group. Групування затехнічним станом  ");
            foreach (var item in car)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine($"\t{item1.Brand} {item1.Model}");
                }
            }
        }
        public void GetDriverSort()
        {
            var driver = _request.GetDriverSort();
            Console.WriteLine($"\tСортуавння водіїв.");
            foreach (var item in driver)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName} {item.MiddleName}");
            }
        }
        public void ValueCarManufacture()
        {
            string country = "France";
            Console.WriteLine($"\tВивести кількість автомобілів виготовлених  в {country} ");
            var car = _request.ValueCarManufacture(country);
            Console.WriteLine(car);
        }
        public void CarWithBodyType()
        {
            var bodytype = CarBodyType.hatchback;
            var car = _request.CarWithBodyType(bodytype);
            Console.WriteLine($"\tВикористання Any. Знайти чи є хоча б один атомобіль {bodytype} ");
            Console.WriteLine(car);
            Console.WriteLine($"{bodytype} є в наявності");
        }
       public void UseElementAt()
        {
            const int index = 1;
            Console.WriteLine($"\tВикористання ElementAt. Вивести об'єкт за вказаним індексом. ");
            var element = _request.UseElementAt(index);
            Console.WriteLine($"{element} має {index} індекс");
        }
        public void UseSkip()
        {
            const int index = 1;
            Console.WriteLine($"\tВикористання Skip. Пропусти об'єкт за вказаним індексом. ");
            var element = _request.UseSkip(index);
            foreach (var item in element)
            {
                Console.WriteLine(item);
            }
        }
        public void JoinDriverCar()
        {
            var odjec = _request.JoinDriverCar();
            Console.WriteLine($"\tВикористання Join. Вивід кількості водіїв, які мають водити обрану машину. ");
            foreach (var item in odjec)
            {
                Console.WriteLine(item);
            }
        }
        public void GetOldestOwner()
        {
            Console.WriteLine($"\tВивести день народження для найстаршого власника автомобіля. ");
            var owner = _request.GetOldestOwner();
            Console.WriteLine(owner);
        }
        public void GetCarsAfterYears()
        {
            const int year = 2015;
            var cars = _request.GetCarsAfterYears(year);
            Console.WriteLine($"\tВивести автомобілі , які були випущені після {year} ");
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Brand} {item.Model} - {item.Year}");
            }
        }
        public void SortRegistrationForRegDate()
        {
            Console.WriteLine($"\t Сортування регістрацій за їх датою.");
            var registration = _request.SortRegistrationForRegDate();
            foreach (var item in registration)
            {
                Console.WriteLine(item);
            }
        }
        public void GetLicenseNumber()
        {
            Console.WriteLine($"\t Використання Concat. Вивести всі ліцензії всіх людей , які водять автомобіль.");
            var element = _request.GetLicenseNumber();
            foreach (var item in element)
            {
                Console.WriteLine(item);
            }
        }
    }
}
