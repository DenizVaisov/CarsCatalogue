using CarsCatalogue.Contracts;
using CarsCatalogue.Models;

namespace CarsCatalogue.Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private ICarRepository _carRepository;
        private ICarDetailsRepository _carDetailsRepository;
 
        public ICarRepository Car {
            get {
                if(_carRepository == null)
                {
                    _carRepository = new CarRepository(_repoContext);
                }
 
                return _carRepository;
            }
        }
        
        public ICarDetailsRepository CarDetails {
            get {
                if(_carDetailsRepository == null)
                {
                    _carDetailsRepository = new CarDetailsRepository(_repoContext);
                }
 
                return _carDetailsRepository;
            }
        }
 
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}