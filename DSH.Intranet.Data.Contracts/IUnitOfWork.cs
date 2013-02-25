using DSH.Intranet.Model;

namespace DSH.Intranet.Data.Contracts
{
    /// <summary>
    /// Interface for the "Unit of Work"
    /// </summary>
    public interface IUnitOfWork
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        IRepository<Security> Security { get; }
    }
}