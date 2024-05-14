using Microsoft.EntityFrameworkCore;

namespace CrudWithWebAPI.Model
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext>options) : base(options)
        {
        }

       public DbSet<Brand> Brands { get; set; }
    }
}
