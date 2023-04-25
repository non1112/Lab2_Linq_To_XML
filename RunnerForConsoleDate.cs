using Lab2_Linq_To_XML.Classes;
using System;
using System.Collections.Generic;

namespace Lab2_Linq_To_XML
{
    class RunnerForConsoleDate
    {
        
        public static List<T> ListValue<T>() where T:class
        {

            List<T> list = new List<T>();

            while (true)
            {
                Console.Write("Хочете заповнити дані ? (Y/N) ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    break;
                }

                var car = new ConsoleReadData();
                var type = typeof(T);
                if (type == typeof(Car))
                {
                    var car1 = car.NewCar();
                    list.Add(car1 as T);
                }
                else if (type == typeof(Driver))
                {
                    var car1 = car.NewDriver();
                    list.Add(car1 as T);
                }
                else if (type == typeof(Owner))
                {
                    var car1 = car.NewOwner();
                    list.Add(car1 as T);
                }
                else if (type == typeof(DriverCar))
                {
                    var car1 = car.NewDriverCar(new ReaderXmlDocument());
                    list.Add(car1 as T);
                }
                else if (type == typeof(Registration))
                {
                    var car1 = car.NewRegistration(new ReaderXmlDocument());
                    list.Add(car1 as T);
                }
            }
            return list;

        }

    }
}
