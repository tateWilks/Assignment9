using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; } //only allowed to get - query - the stuff

        //IQueryable - getting data from outside databases (good for LINQ to SQL)
        //IEnumerable - getting data out of in-memory things (like lists and arrays - good for LINQ to XML)
    }
}
