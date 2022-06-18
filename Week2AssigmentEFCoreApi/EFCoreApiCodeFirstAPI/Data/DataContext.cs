using Microsoft.EntityFrameworkCore;

namespace EFCoreApiCodeFirst.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(option)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
