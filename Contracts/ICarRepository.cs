using System.Collections.Generic;
using CarsCatalogue.Models;

namespace CarsCatalogue.Contracts
{
    public interface ICarRepository: IRepositoryBase<Car>
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int carId);
        void CreateCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
    }
}