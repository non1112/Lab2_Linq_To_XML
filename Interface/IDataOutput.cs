using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_To_XML
{
    interface IDataOutput
    {
        void ShowAll();
        void GetAllCar();
        void CreateXmlFile();
        void Exit();
        void GetManufacturersNotFromCountry();
        void GetBrandsSort();
        void GetLatestCar();
        void GroupCarTechnicalCondition();
        void GetDriverSort();
        void ValueCarManufacture();
        void CarWithBodyType();
        void UseElementAt();
        void UseSkip();
        void JoinDriverCar();
        void GetOldestOwner();
        void GetCarsAfterYears();
        void SortRegistrationForRegDate();
        void GetLicenseNumber();
    }
}
