using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private DatabaseContext _context;
        //constructor
        public EFMovieRepository(DatabaseContext context)
        {
            _context = context;
        }
        public IQueryable<Movie> Movies => _context.Movies; //lambda does something where the variable constantly updates - GOOGLE THIS - it makes an anonymous function - don't want a static instance

    }
}
