using System.Collections.Generic;
using System.Linq;
using CarsCatalogue.Contracts;
using CarsCatalogue.Models;

namespace CarsCatalogue.Repository
{
    public class CarRepository : RepositoryBase<Car>,  ICarRepository
    {
        public CarRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        
        }
        
        public IEnumerable<Car> GetAllCars()
        {
            return FindAll()
                .OrderBy(car => car.title)
                .ToList();
        }
        
        public Car GetCarById(int carId)
        {
            return FindByCondition(car => car.id.Equals(carId))
                .DefaultIfEmpty(new Car())
                .FirstOrDefault();
        }

        public void CreateCar(Car car)
        {
            Create(car);
        }

        public void UpdateCar(Car car)
        {
            Update(car);
        }
        
        public void DeleteCar(Car car)
        {
            Delete(car);
        }
    }
}