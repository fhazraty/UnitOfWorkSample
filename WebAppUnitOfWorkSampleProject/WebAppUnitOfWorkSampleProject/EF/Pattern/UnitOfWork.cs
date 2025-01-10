using WebAppUnitOfWorkSampleProject.EF.Model;
using WebAppUnitOfWorkSampleProject.EF.Repository;

namespace WebAppUnitOfWorkSampleProject.EF.Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IRepository<Product> _products;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IRepository<Product> Products => _products ??= new Repository<Product>(_context);

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
