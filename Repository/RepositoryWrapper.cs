using CarsCatalogue.Contracts;
using CarsCatalogue.Models;

namespace CarsCatalogue.Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private ICarRepository _carRepository;
        //CODEREV: Такие вещи должны работать через Dependency Injection иначе вы теряете инверсию зависимости над CarRepository. Пусть он тоже инжектится через DI
        public ICarRepository Car {
            get {
                if(_carRepository == null)
                {
                    _carRepository = new CarRepository(_repoContext);
                }
 
                return _carRepository;
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