using System;
using System.Linq.Expressions;
using Patterns.Specification.Models;

namespace Patterns.Specification.Specifications
{
    public class YearAndTitleSpecification : Specification<Movie>
    {
        private readonly long _year;
        private readonly string _title;

        public YearAndTitleSpecification(long year, string title)
        {
            _year = year;
            _title = title;
        }

        public override Expression<Func<Movie, bool>> ToExpression()
        {
            return movie =>
                movie.Year <= _year && movie.Title.Contains(_title, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
