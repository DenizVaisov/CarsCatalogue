using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CarsCatalogue.Contracts;
using CarsCatalogue.Models;

namespace CarsCatalogue.Repository
{
    public class CarDetailsRepository : RepositoryBase<CarDetails>, ICarDetailsRepository
    {
        public CarDetailsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public IEnumerable<CarDetails> CarDetailsById(Guid carId)
        {
            return FindByCondition(a => a.cars_id.Equals(carId)).ToList();
        }
    }
}