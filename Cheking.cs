using System;

namespace Lab2_Linq_To_XML
{
    public class Cheking
    {
        public static T ChekingEnumValue<T>(string carType) where T : struct,Enum
        {
            T bodyType;
            while (!Enum.TryParse(carType, out bodyType))
            {
                Console.WriteLine("\tВведенно не коректно тип даниих, ведіть ще раз : ");
                foreach (var type in Enum.GetValues(typeof(T)))
                    Console.WriteLine(type);
                carType = Console.ReadLine();
            }
            return bodyType;
        }
        public static string CheckString(string str)
        {
            while (string.IsNullOrWhiteSpace(str))
            {
                Console.Write("\tСтрока порожня або null, будь-ласка, введіть значення : ");
                str = Console.ReadLine();
            }                
            return str;
        }
        public static int ChekingValue(string value)
        {
            int type;
            while (!Int32.TryParse(value, out type))
            {
                Console.Write("\tВведенно не коректно тип даниих, ведіть ще раз : ");
                value = Console.ReadLine();
            }
            return type;
        }
        public static DateTime ChekingDateTime(string value)
        {
            DateTime type;
            while (!DateTime.TryParse(value, out type))
            {
                Console.Write("\tВведенно не коректно тип даниих, ведіть ще раз : ");
                value = Console.ReadLine();
            }
            return type;
        }

    }
}
