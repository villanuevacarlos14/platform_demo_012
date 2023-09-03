using System.Linq.Expressions;

namespace PlatformDemo.Core.Contracts;

public interface IRepository<T> where T: class
{
    IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] navigationPaths);
}