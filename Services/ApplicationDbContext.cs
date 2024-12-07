using BESTSTORE.Models;
using Microsoft.EntityFrameworkCore;

namespace BESTSTORE.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
