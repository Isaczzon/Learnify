using System.Collections.Generic;
using System.Threading.Tasks;
using Entity.Specification;

namespace Entity.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<T> GetByIdAsync(dynamic id);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> GetEntityWithSpec(ISpecification<T> spec);

        Task<IReadOnlyList<T>> ListWithSpec(ISpecification<T> spec);

        Task<int> CountResultAsync(ISpecification<T> spec);
    }
}