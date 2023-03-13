using Microsoft.EntityFrameworkCore;
using NikeShop.Models;

namespace NikeShop.Data
{
    public class NikeShopContext : DbContext
    {
         public NikeShopContext (DbContextOptions<NikeShopContext> options)
            : base(options)
            {

            }
        public DbSet <Product> Products { get; set; }
        
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
             base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data source=NikeShop.db");
        }
          protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.seed();
        }

    }

}