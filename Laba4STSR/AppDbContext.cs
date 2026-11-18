using Microsoft.EntityFrameworkCore;
using Laba4TSR.Models;

namespace Laba4TSR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; } // <-- ВОТ ЗДЕСЬ ДОЛЖНЫ БЫТЬ КЛИЕНТЫ
    }
}