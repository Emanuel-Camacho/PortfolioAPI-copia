using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data.Entities;

namespace PortfolioAPI.Data
{
    public class ApplicationContext : DbContext
    {
        // representa una lista de tipo <Experience> en la base de datos y el nombre de la tabla es Experiences
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "password"
                }
            );
        }
        
    }
}
