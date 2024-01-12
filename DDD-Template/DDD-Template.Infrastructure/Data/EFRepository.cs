using Ardalis.SharedKernel;
using Ardalis.Specification.EntityFrameworkCore;

namespace DDD_Template.Infrastructure.Data
{
    // inherit from Ardalis.Specification type
    public class EFRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
    {
        public EFRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
