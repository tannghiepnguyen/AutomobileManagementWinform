using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.BusinessObject
{
    public class Car
    {
        public Car(int carID, string carName, string manufacturer, decimal price, int releaseYear)
        {
            this.CarID = carID;
            this.CarName = carName; 
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.ReleaseYear = releaseYear;
        }
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int ReleaseYear { get; set; }
    }
}
