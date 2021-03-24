using Assignment9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment9.Models.ViewModels;

namespace Assignment9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMovieRepository _repository;
        public int iPageSize = 20;

        public HomeController(ILogger<HomeController> logger, IMovieRepository repo)
        {
            _logger = logger;
            _repository = repo;
        }

        //View for the index page
        public IActionResult Index()
        {
            return View();
        }

        //view for showing the add movie form
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        //view for posting the add movie form
        [HttpPost]
        public IActionResult AddMovie(Movie movie, int iPageNum = 1)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                movie.MovieID = _repository.Movies.OrderBy(m => m.MovieID).Last().MovieID + 1;

                string conn = @"DataSource=C:\Users\Tatew\IS_Core\Winter\IS413\source\Assignment9\MovieCollection.sqlite";
                SqliteConnection sqlConn = new SqliteConnection(conn);

                sqlConn.Open();

                SqliteCommand cmd = sqlConn.CreateCommand();

                cmd.CommandText = "INSERT INTO MOVIES (MovieID, Category, Director, Edited, LentTo, MovieTitle, Notes, Rating, YearReleased) VALUES (@movieId, @category, @director, @edited, @lentto, @movietitle, @notes, @rating, @year)";
                cmd.Parameters.AddWithValue("@movieId", movie.MovieID);
                cmd.Parameters.AddWithValue("@category", movie.Category);
                cmd.Parameters.AddWithValue("@director", movie.Director);
                cmd.Parameters.AddWithValue("@edited", movie.Edited ? "No" : "Yes"); //the nullable values are giving me issues with this.... need to see another solution
                cmd.Parameters.AddWithValue("@lentto", System.String.IsNullOrEmpty(movie.LentTo) ? "" : movie.LentTo);
                cmd.Parameters.AddWithValue("@movietitle", movie.MovieTitle);
                cmd.Parameters.AddWithValue("@notes", System.String.IsNullOrEmpty(movie.Notes) ? "" : movie.Notes);
                cmd.Parameters.AddWithValue("@rating", movie.Rating);
                cmd.Parameters.AddWithValue("@year", movie.YearReleased);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                sqlConn.Close();

                return View("Movies", new MovieListViewModel
                {
                    Movies = _repository.Movies
                    .OrderBy(m => m.MovieID)
                    .Skip((iPageNum - 1) * iPageSize)
                    .Take(iPageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = iPageNum,
                        MoviesPerPage = iPageSize,
                        TotalNumMovies = _repository.Movies.Count()
                    }
                });
            }            
        }

        //view to display all the movies
        public IActionResult Movies(int iPageNum = 1)
        {
            //using a view model so we can have some pagination
            return View(new MovieListViewModel
            {
                Movies = _repository.Movies
                    .OrderBy(m => m.MovieID)
                    .Skip((iPageNum - 1) * iPageSize)
                    .Take(iPageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = iPageNum,
                    MoviesPerPage = iPageSize,
                    TotalNumMovies = _repository.Movies.Count()
                }
            });
        }
        
        [HttpPost]
        public IActionResult EditMovie(int movieId)
        {
            //This is giving me problems
            //This works though - why does this work? need to work through this
            //IQueryable<Movie> em = from m in _repository.Movies where m.MovieID == movieId select m;
            Movie mov = (from m in _repository.Movies where m.MovieID == movieId select m).First();
            //Movie editMovie = em.First();

            //return the view with the movie object
            return View(mov);
        }


        [HttpPost]
        public IActionResult ConfirmEdit(Movie movie, int iPageNum = 1) //struggling to pass a true/false value to the controller to pass back to the database
        {
            if (!ModelState.IsValid)
            {
                return View("EditMovie");
            } 
            else
            {
                string conn = @"DataSource=C:\Users\Tatew\IS_Core\Winter\IS413\source\Assignment9\MovieCollection.sqlite";
                SqliteConnection sqlConn = new SqliteConnection(conn);

                sqlConn.Open();

                SqliteCommand cmd = sqlConn.CreateCommand();

                cmd.CommandText = "UPDATE MOVIES SET Category=@category, Director=@director, Edited=@edited, LentTo=@lentto, MovieTitle=@movietitle, Notes=@notes, Rating=@rating, YearReleased=@year WHERE MovieID=@movieId";
                cmd.Parameters.AddWithValue("@movieId", movie.MovieID);
                cmd.Parameters.AddWithValue("@category", movie.Category);
                cmd.Parameters.AddWithValue("@director", movie.Director);
                cmd.Parameters.AddWithValue("@edited", movie.Edited ? "No" : "Yes"); //the nullable values are giving me issues with this.... need to see another solution
                cmd.Parameters.AddWithValue("@lentto", System.String.IsNullOrEmpty(movie.LentTo) ? "" : movie.LentTo);
                cmd.Parameters.AddWithValue("@movietitle", movie.MovieTitle);
                cmd.Parameters.AddWithValue("@notes", System.String.IsNullOrEmpty(movie.Notes) ? "" : movie.Notes);
                cmd.Parameters.AddWithValue("@rating", movie.Rating);
                cmd.Parameters.AddWithValue("@year", movie.YearReleased);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                sqlConn.Close();

                return View("Movies", new MovieListViewModel
                {
                    Movies = _repository.Movies
                    .OrderBy(m => m.MovieID)
                    .Skip((iPageNum - 1) * iPageSize)
                    .Take(iPageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = iPageNum,
                        MoviesPerPage = iPageSize,
                        TotalNumMovies = _repository.Movies.Count()
                    }
                });
            }
        }


        //Delete a movie
        [HttpPost]
        public IActionResult DeleteMovie(int movieId, int iPageNum = 1)
        {
            string conn = @"DataSource=C:\Users\Tatew\IS_Core\Winter\IS413\source\Assignment9\MovieCollection.sqlite";
            SqliteConnection sqlConn = new SqliteConnection(conn);

            sqlConn.Open();

            SqliteCommand cmd = sqlConn.CreateCommand();

            cmd.CommandText = "DELETE FROM MOVIES WHERE MovieID=@movieId";
            cmd.Parameters.AddWithValue("@movieId", movieId);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            sqlConn.Close();

            return View("Movies", new MovieListViewModel
            {
                Movies = _repository.Movies
                .OrderBy(m => m.MovieID)
                .Skip((iPageNum - 1) * iPageSize)
                .Take(iPageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = iPageNum,
                    MoviesPerPage = iPageSize,
                    TotalNumMovies = _repository.Movies.Count()
                }
            });
        }

        //view to show the link to the podcasts
        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
