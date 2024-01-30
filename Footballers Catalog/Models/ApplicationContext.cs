using Footballers_Catalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Footballers_Catalog.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Team> Teams { get; set; } 
        public DbSet<Footballer> Footballers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(u => u.Name);
        }
    }
}
