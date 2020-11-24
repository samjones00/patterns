using System;
using System.Linq.Expressions;
using Patterns.Specification.Models;

namespace Patterns.Specification.Specifications
{
    public class YearSpecification : Specification<Movie>
    {
        private readonly long _year;

        public YearSpecification(long year)
        {
            _year = year;
        }

        public override Expression<Func<Movie, bool>> ToExpression()
        {
            return movie => movie.Year <= _year;
        }
    }
}
