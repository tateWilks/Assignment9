using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumMovies { get; set; }
        public int MoviesPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumMovies / MoviesPerPage)); //cast to decimal, divide, round up, cast back to int - use a lambda to make sure that the instance can change - don't want to be stuck with just one value
    }
}
