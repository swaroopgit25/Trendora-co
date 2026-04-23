using Ardalis.Specification.EntityFrameworkCore;
using Trendora.ApplicationCore.Interfaces;

namespace Trendora.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(CatalogContext dbContext) : base(dbContext)
    {
    }
}

