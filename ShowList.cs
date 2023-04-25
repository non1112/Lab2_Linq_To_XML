using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_To_XML
{
    public class ShowList
    {
        public static void ShowFile<T>(IEnumerable<T> list)
        {
            Console.WriteLine($"{typeof(T).Name}");
            foreach (var item in list)
                Console.WriteLine($"\t {item}");
            Console.WriteLine();
        }
    }
}
