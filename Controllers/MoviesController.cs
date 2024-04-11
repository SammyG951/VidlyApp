using Microsoft.AspNetCore.Mvc;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
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
            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Wall-E"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies,
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
