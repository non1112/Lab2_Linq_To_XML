using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_Linq_To_XML
{
    interface IDataContent
    {
        XDocument Cars { get; }
        XDocument Drivers { get; }

        XDocument Owners { get; }
        XDocument Registration { get; }
        XDocument DriverCar { get; }

    }
}
