using LuxGamingShop1.Models.ContactUs;
using Microsoft.EntityFrameworkCore;

namespace LuxGamingShop1.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Gaming> Gamings { get; set; }
        public DbSet<HomeH> HomeHs { get; set; }
        public DbSet<TrendingGame> TrendingGames { get; set; }
        public DbSet<ContactUss> contactUs { get; set; }





    }
}
