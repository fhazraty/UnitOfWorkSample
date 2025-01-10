using WebAppUnitOfWorkSampleProject.EF.Model;
using WebAppUnitOfWorkSampleProject.EF.Repository;

namespace WebAppUnitOfWorkSampleProject.EF.Pattern
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        Task<int> CompleteAsync();
    }
}
