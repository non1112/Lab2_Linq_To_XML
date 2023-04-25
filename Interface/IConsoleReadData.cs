using Lab2_Linq_To_XML.Classes;


namespace Lab2_Linq_To_XML
{
   interface IConsoleReadData
    {
        Car NewCar();
        Driver NewDriver();
        Owner NewOwner();
        DriverCar NewDriverCar(ReaderXmlDocument reader);
        Registration NewRegistration(ReaderXmlDocument reader);
    }
}
