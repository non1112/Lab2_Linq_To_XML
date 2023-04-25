using System.Xml.Linq;

namespace Lab2_Linq_To_XML
{
    public class DataContent : IDataContent
    {
        public XDocument Cars =>XDocument.Load(PathWay.Car);

        public XDocument Drivers => XDocument.Load(PathWay.Driver);

        public XDocument Owners =>  XDocument.Load(PathWay.Owner);

        public XDocument Registration => XDocument.Load(PathWay.Registration);

        public XDocument DriverCar => XDocument.Load(PathWay.DriverCar);
    }
}
