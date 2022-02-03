using CarRentalSystem.Models;
using CarRentalSystem.util;

namespace CarRentalSystem.Utils
{
    public interface IHelpercs 
    {
        public void SaveCarDetailsToFile(Car newCarObj);
        public void SaveCarDetailsToFile(string fileName);
    }
}
