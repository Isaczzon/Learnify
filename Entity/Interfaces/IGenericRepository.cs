using System.Collections.Generic;
using System.Threading.Tasks;

namespace Entity.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<T> GetByIdAsync(dynamic id);

        Task<IReadOnlyList<T>> ListAllAsync();
    }
}