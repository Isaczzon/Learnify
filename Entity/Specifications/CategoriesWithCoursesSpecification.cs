using System;
using System.Linq.Expressions;
using Entity.Specification;

namespace Entity.Specifications
{
    public class CategoriesWithCoursesSpecification : BaseSpecification<Category>
    {
        public CategoriesWithCoursesSpecification(int id) : base(x => x.Id == id)
        {
            IncludeMethod(c => c.Courses);
            SortMethod(x => x.Id);
        }
    }
}