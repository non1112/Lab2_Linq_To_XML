

namespace Lab2_Linq_To_XML.Classes
{
    public class DriverCar
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int CarId { get; set; }

        public override string ToString() { return $"  водій айді: { DriverId} - машина айді  { CarId } "; }
    }
}
