using EntityFramework.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Repository
{
    public class Repository : IRepository<Product>
    {
        public IQueryable<Product> All { get; }

        private DbSet<Product> Table => _testTaskDBContext.Set<Product>();
        private readonly TestTaskDBContext _testTaskDBContext;

        public Repository(TestTaskDBContext testTaskDBContext)
        {
            _testTaskDBContext = testTaskDBContext;
            All = Table.Include(e => e.Category);
        }

    }
}
