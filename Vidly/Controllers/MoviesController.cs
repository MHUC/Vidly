using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;


        public MoviesController()
        {

            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

      
       

        //public ActionResult Edit( int id)
        //{
        //    return Content("Id=" + id);
        //}


        public ActionResult Index()
        {

            var movie = _context.Movies.Include(c => c.Genre).ToList();


            return View(movie);
        }


        public ActionResult Details(int id)
        {
          
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                HttpNotFound();

            return View(movie);
        }

        public ActionResult New()
        {
            var genre = _context.Genres.ToList();
            var viewModel = new RandomMovieViewModel
            {
                Movies = new Movie(),
                Genres = genre
            };

            return View("MovieForm", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {

            movie.CreatedDate = System.DateTime.Now;
            if (!ModelState.IsValid)
            {

                var viewModel = new RandomMovieViewModel
                {
                    Movies = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);

            }



            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.CreatedDate = System.DateTime.Now;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }



        public ActionResult Edit(int id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();


            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

    }
}