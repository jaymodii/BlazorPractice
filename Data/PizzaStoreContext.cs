
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
    }
}
