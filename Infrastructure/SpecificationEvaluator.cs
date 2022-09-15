using System.Linq;
using Entity.Specification;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SpecificationEvaluator<T> where T : class
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {
            var query = inputQuery;

            if(spec.Criteria != null)
            {
                query = query.Where(spec.Criteria); // x => x.Id == id
            }

            query = spec.Include.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}