using Microsoft.AspNetCore.Mvc;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Luke Skywalker", Id = 0 },
                new Customer { Name = "Princess Leia", Id = 1}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };


            return View(viewModel);
        }

        public IActionResult Details(int id)
        {

            var customer = new Customer();

            if (id == 0)
            {
                customer = new Customer { Name = "Luke Skywalker" };
            }
            else if (id == 1)
            {
                customer = new Customer { Name = "Princess Leia" };
            }
            else
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
