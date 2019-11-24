namespace CarsCatalogue.Contracts
{
    public interface IRepositoryWrapper
    {
        ICarRepository Car { get; }
        void Save();
    }
}