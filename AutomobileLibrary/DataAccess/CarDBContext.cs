using AutomobileLibrary.BusinessObject;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //Initialize car list
        private static List<Car> carList = new List<Car>()
        {
            new Car(1,"CRV","Honda",30000,2021),
            new Car(2,"Ford Focus","Ford",15000, 2020)
        };

        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Car> getCarList => carList;

        public Car getCarByID(int carID)
        {
            Car car = carList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }

        public void addNew(Car car)
        {
            Car pro = getCarByID(car.CarID);
            if (pro == null)
            {
                carList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }

        public void update(Car car)
        {
            Car c = getCarByID(car.CarID);
            if (c != null)
            {
                int index = carList.IndexOf(c);
                carList[index] = car;
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }
        public void remove(int CarID)
        {
            Car p = getCarByID(CarID);
            if (p != null)
            {
                carList.Remove(p);
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }
    }
}
