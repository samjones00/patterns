using System.Collections.Generic;
using System.Linq;
using Patterns.Specification.Models;
using Patterns.Specification.Specifications;

namespace Patterns.Specification.Repositories
{
    public class MovieRepository
    {
        public IQueryable<Movie> Data;

        public IReadOnlyList<Movie> Find(Specification<Movie> specification)
        {
            Data = new List<Movie>()
            {
                new Movie("Avatar", 2012),
                new Movie("Terminator", 1987),
                new Movie("Toy Story", 2000),
            }.AsQueryable();

            return Data
                .Where(specification.ToExpression())
                .ToList();
        }
    }
}
