using Microsoft.EntityFrameworkCore;

namespace lab08_codefirst.Models
{
    public class EShopV10 : DbContext
    {
        public EShopV10(DbContextOptions<EShopV10> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
