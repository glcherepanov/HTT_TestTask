using EntityFramework.Entity;

namespace EntityFramework.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> All { get; }
    }
}
