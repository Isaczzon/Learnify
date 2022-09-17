using System;
using System.Linq.Expressions;
using Entity.Specification;

namespace Entity.Specifications
{
    public class CoursesFiltersCountSpecification : BaseSpecification<Course>
    {
        public CoursesFiltersCountSpecification(CourseParams courseParams) : base(x =>
        !courseParams.CategoryId.HasValue || x.CategoryId == courseParams.CategoryId)
        {
        }
    }
}