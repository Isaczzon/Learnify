using System.Collections.Generic;
using System.Threading.Tasks;

namespace Entity.Interfaces
{
    public interface ICategoryRepository
    {
         Task<Category> GetCategoriesByIdAsync(int id);

         Task<IReadOnlyList<Category>> GetCategoriesAsync();
    }
}