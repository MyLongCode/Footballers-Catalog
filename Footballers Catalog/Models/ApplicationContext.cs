using Footballers_Catalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Footballers_Catalog.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
