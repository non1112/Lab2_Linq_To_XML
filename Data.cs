using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_Linq_To_XML
{
    public class Data
    {
        public static IEnumerable<Car> Cars = new List<Car>()
        {
        new Car() {Id=1,Brand="BMW",Model="M5",BodyType=CarBodyType.sedan,VIN="1231413432",Manufacturer="Germany",Year=2010,Color="Black",LicensePlate="АМ1234КМ",TechnicalCondition=CarTechnicalCondition.AfterTheCrash},
        new Car() {Id=2,Brand="Audi",Model="A34",BodyType=CarBodyType.universal,VIN="2343413432",Manufacturer="Germany",Year=2009,Color="White",LicensePlate="АМ3243КП",TechnicalCondition=CarTechnicalCondition.New},
        new Car() {Id=3,Brand="Bugatti",Model="Veyron",BodyType=CarBodyType.universal,VIN="7568765467",Manufacturer="France",Year=2008,Color="Green",LicensePlate="АК7777НВ",TechnicalCondition=CarTechnicalCondition.Working},
        new Car() {Id=4,Brand="Opel",Model="R3",BodyType=CarBodyType.sedan,VIN="1232973332",Manufacturer="France",Year=2017,Color="Green",LicensePlate="АК1534АС",TechnicalCondition=CarTechnicalCondition.AfterTheCrash},
        new Car() {Id=5,Brand="Tayota",Model="G5",BodyType=CarBodyType.sedan,VIN="3457213432",Manufacturer="Japan",Year=2015,Color="Black",LicensePlate="АП2343НА",TechnicalCondition=CarTechnicalCondition.AfterTheCrash},
        new Car() {Id=6,Brand="BMW",Model="M435",BodyType=CarBodyType.hatchback,VIN="5263748368",Manufacturer="Germany",Year=2012,Color="White",LicensePlate="КМ3243ТР",TechnicalCondition=CarTechnicalCondition.New},
        new Car() {Id=7,Brand="Tayota",Model="M12",BodyType=CarBodyType.hatchback,VIN="0423943432",Manufacturer="Japan",Year=2013,Color="Green",LicensePlate="АЕ2342РС",TechnicalCondition=CarTechnicalCondition.Working}
        };
        public static IEnumerable<Owner> Owners = new List<Owner>()
        {
          new Owner(){Id = 1,LastName = "Поліщук", FirstName = "Віктор",MiddleName = "Вікторович",DateOfBirth = new DateTime(2004, 3, 2),DriverLicenseNumber = "23123123432",RegistrationAddress = "Шевченка 45А" },
          new Owner(){Id = 2, LastName = "Нікітіна",FirstName = "Наталія", MiddleName = "Юріївна",DateOfBirth = new DateTime(2002, 4, 12),DriverLicenseNumber = "31229887932",RegistrationAddress = "Сарни 12"},
          new Owner(){Id = 3,LastName = "Паламарчук",FirstName = "Дмитро", MiddleName = "Васильович",DateOfBirth = new DateTime(2000, 1, 22),DriverLicenseNumber = "56765543545", RegistrationAddress = "Котляревського 4А"},
          new Owner(){Id = 4,LastName = "Поліщук",FirstName = "Степан",MiddleName = "Стенпанович",DateOfBirth = new DateTime(1998, 3, 23), DriverLicenseNumber = "96786574565", RegistrationAddress = "Мічурина 7"},
          new Owner(){ Id = 5, LastName = "Стефанюк",FirstName = "Віктор",MiddleName = "Денисович",DateOfBirth = new DateTime(1994, 6, 23),DriverLicenseNumber = "96796756756",RegistrationAddress = "Шевченка 45/А"},
          new Owner(){ Id = 6,LastName = "Кулінар",FirstName = "Євген",MiddleName = "Вікторович",DateOfBirth = new DateTime(2004, 7, 14), DriverLicenseNumber = "85676456453", RegistrationAddress = "Каневського 32"},
          new Owner(){Id = 7,LastName = "Мозайчук",FirstName = "Микита",MiddleName = "Артемович",DateOfBirth = new DateTime(2002, 7, 13),DriverLicenseNumber = "96885463452",RegistrationAddress = "Коростенщина 36А"},
          new Owner(){Id = 8,LastName = "Малярчук", FirstName = "Андрій",MiddleName = "Артемович",DateOfBirth = new DateTime(2004, 8, 8),DriverLicenseNumber = "64756354544",RegistrationAddress = "Мічурина 7"},
          new Owner(){ Id = 9,LastName = "Мазуренко",FirstName = "Дмитро",MiddleName = "Олександрович",DateOfBirth = new DateTime(2000, 11, 5),DriverLicenseNumber = "34563456765",RegistrationAddress = "Шевченка 45А"}
        };
        public static IEnumerable<Driver> Drivers = new List<Driver>
        {
            new Driver(){Id=1,LastName="Василенко",FirstName="Андрій",MiddleName="Вікторович" , DateOfBirth=new DateTime(1993,7,2), DriverLicenseNumber= "47367485737", RegistrationAddress="Шевченка 45А"},
            new Driver(){Id=2,LastName="Андрієнко",FirstName="Андрій",MiddleName="Михайлович" , DateOfBirth=new DateTime(2001,4,12), DriverLicenseNumber="32445225532", RegistrationAddress="Сарни 12"},
            new Driver(){Id=3,LastName="Гуцілюк",FirstName="Михайло",MiddleName="Степанович" , DateOfBirth=new DateTime(2003,1,22), DriverLicenseNumber= "23432423443", RegistrationAddress="Котляревського 4А"},
            new Driver(){Id=4,LastName="Білошицький",FirstName="Олег",MiddleName="Дмитриєвич" , DateOfBirth=new DateTime(1998,3,23), DriverLicenseNumber="67456553665", RegistrationAddress="Мічурина 7"},
            new Driver(){Id=5,LastName="Степаненко",FirstName="Олександр",MiddleName="Денисович" , DateOfBirth=new DateTime(1994,6,23), DriverLicenseNumber="35345435345", RegistrationAddress="Шевченка 45/А"},
            new Driver(){Id=6,LastName="Прокопюк",FirstName="Віктор",MiddleName="Макарович" , DateOfBirth=new DateTime(2004,7,14), DriverLicenseNumber=  "45345345534", RegistrationAddress="Каневського 32"},
            new Driver(){Id=7,LastName="Ярошовець",FirstName="Євген",MiddleName="Олегович" , DateOfBirth=new DateTime(2002,7,13), DriverLicenseNumber=   "85767463457", RegistrationAddress="Коростенщина 36А"},
            new Driver(){Id=8,LastName="Берчук",FirstName="Олексій",MiddleName="Артемович" , DateOfBirth=new DateTime(2004,8,8), DriverLicenseNumber=    "97897888888", RegistrationAddress="Мічурина 7"},
            new Driver(){Id=9,LastName="Білецький",FirstName="Захар",MiddleName="Олександрович" , DateOfBirth=new DateTime(2000,11,5), DriverLicenseNumber="89789897897", RegistrationAddress="Шевченка 45А"},
        };
        public static IEnumerable<Registration> Registrations = new List<Registration>
        {
             new Registration(){Id=1, RegistrationDate=new DateTime(2020,5,23) ,CarId=1,OwnerId=1},
             new Registration(){Id=2, RegistrationDate=new DateTime(2015,7,1) ,CarId=2,OwnerId=2},
             new Registration(){Id=3, RegistrationDate=new DateTime(2016,6,2) ,CarId=3,OwnerId=3},
             new Registration(){Id=4, RegistrationDate=new DateTime(2018,1,3) ,CarId=4,OwnerId=4},
             new Registration(){Id=5, RegistrationDate=new DateTime(2019,12,12) ,CarId=5,OwnerId=5},
             new Registration(){Id=6, RegistrationDate=new DateTime(2021,11,10) ,CarId=6,OwnerId=6},
             new Registration(){Id=7, RegistrationDate=new DateTime(2022,1,11) ,CarId=7,OwnerId=7},
             new Registration(){Id=8, RegistrationDate=new DateTime(2019,10,12) ,CarId=3,OwnerId=8},
             new Registration(){Id=9, RegistrationDate=new DateTime(2018,9,10) ,CarId=6,OwnerId=8},
             new Registration(){Id=10,RegistrationDate=new DateTime(2014,7,9),CarId=1,OwnerId=3},
             new Registration(){Id=11,RegistrationDate=new DateTime(2012,6,8),CarId=2,OwnerId=9},
             new Registration(){Id=12,RegistrationDate=new DateTime(2011,5,7),CarId=2,OwnerId=3},
             new Registration(){Id=13,RegistrationDate=new DateTime(2017,3,6),CarId=3,OwnerId=4},
             new Registration(){Id=14,RegistrationDate=new DateTime(2016,2,5),CarId=5,OwnerId=9},
        };
        public static IEnumerable<DriverCar> DriversCars = new List<DriverCar>
        {

            new DriverCar(){Id=1,DriverId=1,CarId=1},
            new DriverCar(){Id=2,DriverId=2,CarId=2},
            new DriverCar(){Id=3,DriverId=3,CarId=3},
            new DriverCar(){Id=4,DriverId=4,CarId=4},
            new DriverCar(){Id=5,DriverId=5,CarId=5},
            new DriverCar(){Id=6,DriverId=6,CarId=6},
            new DriverCar(){Id=7,DriverId=7,CarId=7},
            new DriverCar(){Id=8,DriverId=8,CarId=4},
            new DriverCar(){Id=9,DriverId=9,CarId=3},
        };
    }
}
