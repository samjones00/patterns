using System;
using System.Collections.Generic;
using Patterns.Specification.Models;
using Patterns.Specification.Repositories;
using Patterns.Specification.Specifications;

namespace Patterns.Specification
{
    class Program
    {
        //https://enterprisecraftsmanship.com/posts/specification-pattern-c-implementation/
        static void Main(string[] args)
        {
            var genericRepository = new GenericRepository();

            var specification1 = new GenericSpecification<Movie>(x=>x.Year > 2000);
            var movies1 = genericRepository.Find(specification1);

            var repository = new MovieRepository();
            
            var specification2 = new YearSpecification(2000);
            var movies2 = repository.Find(specification2);

            var specification3 = new YearAndTitleSpecification(2000,"inator");
            var movies3 = repository.Find(specification3);
        }
    }
}
