using EldenRingArKalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace EldenRingArKalculator.Data
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
            { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List<double>>().HasNoKey();
        }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
