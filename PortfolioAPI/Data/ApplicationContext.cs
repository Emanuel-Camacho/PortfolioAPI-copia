using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Data.Entities;

namespace PortfolioAPI.Data
{
    // La clase ApplicationContext hereda de DbContext (metodos, propidades, funcionalidades)
    public class ApplicationContext : DbContext
    {

        // representa una lista de tipo <Experience> en la base de datos y el nombre de la tabla es Experiences
        // DbSet crea una tabla llamada Experiences que almacena objetos tipo Experience
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<User> Users { get; set; }

        // linea necesaria para configurar el contexto
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        // se precarga un usuario para validar
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // HasData carga el usuario inicial
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
