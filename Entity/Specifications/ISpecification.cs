using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Entity.Specification
{
    public interface ISpecification<T>
    {
         Expression<Func<T, bool>> Criteria {get;}

         List<Expression<Func<T, object>>> Include {get;}

         Expression<Func<T, object>> Sort {get;}

         Expression<Func<T, object>> SortByDescending {get;}

    }
}