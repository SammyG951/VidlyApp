using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class CustomersViewModel
    {
        public IEnumerable<Customer>? Customers { get; set; }
        public Customer? Customer { get; set; }
    }
}
