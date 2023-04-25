using Lab2_Linq_To_XML.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_To_XML.Interface
{
    interface ICommandInvoker
    {
        Dictionary<Command, Action> RunCommand();
    }
}
