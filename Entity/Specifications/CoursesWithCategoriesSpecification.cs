using System;
using System.Linq.Expressions;
using Entity.Specification;

namespace Entity.Specifications
{
    public class CoursesWithCategoriesSpecification : BaseSpecification<Course>
    {
        public CoursesWithCategoriesSpecification()
        {
            IncludeMethod(x => x.Category);
        }

        public CoursesWithCategoriesSpecification(Guid id) : base(x => x.Id == id)
        {
            IncludeMethod(c => c.Requirements);
            IncludeMethod(c => c.Learnings);
        }
    }
}