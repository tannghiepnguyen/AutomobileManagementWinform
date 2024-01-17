using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {

        public void deleteCar(int carId) => CarDBContext.Instance.remove(carId);


        public Car getCarbyID(int carId) => CarDBContext.Instance.getCarByID(carId);

        public IEnumerable<Car> getCars() => CarDBContext.Instance.getCarList;

        public void insertCar(Car car) => CarDBContext.Instance.addNew(car);

        public void updateCar(Car car) => CarDBContext.Instance.update(car);
    }
}
