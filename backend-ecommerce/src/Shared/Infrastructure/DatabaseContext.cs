using Microsoft.EntityFrameworkCore;
using backend_ecommerce.src.Backoffice.Products.Domain;

namespace backend_ecommerce.Src.Shared.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products{ get; set; }
    }
}

