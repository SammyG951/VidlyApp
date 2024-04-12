using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        private VidlyDbContext _context;

        public CustomersController()
        {
            _context = new VidlyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };


            return View(viewModel);
        }

        public IActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            var viewModel = new CustomersViewModel
            {
                Customer = customer
            };

            return View(viewModel);
        }
    }
}
