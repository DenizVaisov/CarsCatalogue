using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CarsCatalogue.Models;

namespace CarsCatalogue.Contracts
{
    public interface ICarDetailsRepository : IRepositoryBase<CarDetails>
    {
        IEnumerable<CarDetails> CarDetailsById (Guid carId);
    }
}