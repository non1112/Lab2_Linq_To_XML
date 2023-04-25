using System;

namespace Lab2_Linq_To_XML.Classes
{
    public class Registration
    {
       
        public int Id { get; set; }
        public int CarId { get; set; }
        public int OwnerId { get; set; }
        public DateTime RegistrationDate { get; set; }

        public override string ToString() { return $"  Власник айді : {OwnerId} - айді машини { CarId} зареєстрована { RegistrationDate} "; }


    }
}
