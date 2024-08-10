using ASP.NetHomework3.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NetHomework3.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) 
        : base(options) { }
        
        public DbSet<Product> Products { get; set; }
        
    }
}
