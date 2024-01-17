using System;
using System.Collections.Generic;
using AutomobileLibrary.BusinessObject;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> getCars();
        Car getCarbyID(int carId);
        void insertCar(Car car);
        void deleteCar(int carId);
        void updateCar(Car car);
    }
}
