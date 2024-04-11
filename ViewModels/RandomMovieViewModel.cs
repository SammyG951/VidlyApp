using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public required Movie Movie { get; set; }
        public required List<Customer> Customer { get; set; }
    }
}
