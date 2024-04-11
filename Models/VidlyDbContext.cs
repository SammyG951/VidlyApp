using System.Data.Entity;

namespace VidlyApp.Models
{
    public class VidlyDbContext : DbContext
    {

        public VidlyDbContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
