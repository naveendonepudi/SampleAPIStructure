using System.Linq;
using System.Threading.Tasks;

namespace SolutionName.EntityFrameworkLayer
{
    public interface IRepositoryService<TEntity> where TEntity : class, new()
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task Delete(TEntity entity);
    }
}
