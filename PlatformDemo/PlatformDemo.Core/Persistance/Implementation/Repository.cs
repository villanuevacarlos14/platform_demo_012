using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PlatformDemo.Core.Contracts;

namespace PlatformDemo.Core.Implementation;

public class Repository<T> : IRepository<T> where T: class
{
    private readonly PlatformDemoDbContext _dbContext;

    public Repository(PlatformDemoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, Expression<Func<T, object>>[] navigationPaths = null)
    {
        var query = _dbContext.Set<T>().AsQueryable();

        if (navigationPaths is not null)
        {
            query = navigationPaths.Aggregate(query, (current, path) => current.Include(path).AsQueryable());
        }

        if (predicate is not null)
        {
            query = query.Where(predicate);
        }

        return query.AsNoTracking();
    }
}