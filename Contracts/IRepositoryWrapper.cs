namespace CarsCatalogue.Contracts
{
    public interface IRepositoryWrapper
    {
        ICarRepository Car { get; }
        ICarDetailsRepository CarDetails { get; }
        void Save();
    }
}