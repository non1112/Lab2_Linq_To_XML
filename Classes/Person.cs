using System;


namespace Lab2_Linq_To_XML.Classes
{
    public abstract class Person
    {
  
        public int Id { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }

        
        public string RegistrationAddress { get; set; }

        public override string ToString() { return $"  { LastName} { FirstName} { MiddleName} "; }
    }
}
