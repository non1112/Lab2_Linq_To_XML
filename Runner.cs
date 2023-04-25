using Lab2_Linq_To_XML.Classes;
using Lab2_Linq_To_XML.Enums;
using Lab2_Linq_To_XML.Interface;
using System;

namespace Lab2_Linq_To_XML
{
    class Runner:IRunner
    {
        private ICommandInvoker _commandInvoker;
         public Runner(ICommandInvoker commandInvoker)
         {
             _commandInvoker = commandInvoker;
         }
        public void Run()
         {
            Console.Write("\tВведіть номер запиту від 1-15. Вихід - 0. Зміст файлів- 16.Створення Xml файлів -17 : ");
             if (Enum.TryParse(Console.ReadLine(), out Command command) && _commandInvoker.RunCommand().ContainsKey(command))
             {
                  _commandInvoker.RunCommand()[command](); 
             }
             else
             {
                  Console.WriteLine("НЕ вірно ведене число , введіть число від 1-15");
             }
          
        }
       
    }
}
