using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        private VidlyDbContext _context;

        public MoviesController()
        {
            _context = new VidlyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer> {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            var viewModel = new MoviesViewModel
            {
                Movies = movies,
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var viewModel = new MoviesViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }

        [Route("movies/released/{{year}}/{{month:regex(\\d{{2}}):range(1,12)}}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "-" + month);
        }
    }
}
