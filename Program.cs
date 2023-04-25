
using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Lab2_Linq_To_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.Unicode;
            IDataContent dt = new DataContent();
            IRequest req = new Request(dt);
            IDataOutput data = new DataOutput(req);
            ICommandInvoker commandInvoker = new CommandInvoker(data);
            IRunner rn = new Runner(commandInvoker);
            while (true)
             {
                 bool val1 = Validator.Validate(PathWay.Car, PathWay.CarSchema);
                 bool val2 = Validator.Validate(PathWay.Driver, PathWay.DriverSchema);
                 bool val3 = Validator.Validate(PathWay.Owner, PathWay.OwnerSchema);
                 bool val4 = Validator.Validate(PathWay.Registration, PathWay.RegistrationSchema);
                 bool val5 = Validator.Validate(PathWay.DriverCar, PathWay.DriverCarSchema);
                 if(val1==true&&val2==true && val3 == true && val4 == true && val5 == true)
                 {
                     rn.Run();
                 }
                 else
                 {
                     Console.WriteLine("Нажаль, один з ваших файлів не є валідним ");
                     Console.WriteLine("Для того щоб працювати далі в програмі , перезапишіть файл коректними данними");
                     data.CreateXmlFile();
                 }
             }
        
     
        }
            
    }
}
