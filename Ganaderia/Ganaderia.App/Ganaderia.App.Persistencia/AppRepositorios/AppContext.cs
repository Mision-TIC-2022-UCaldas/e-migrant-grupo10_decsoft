using Microsoft.EntityFrameworkCore;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Migrante> Migrantes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Decsoft");
                //admganaderia31
                //catalog:base de datos
                //
                //optionsBuilder.UseSqlServer("Server=tcp:grupo-31.database.windows.net,1433;Initial Catalog=Grupo31;Persist Security Info=False;User ID=admganaderia31;Password=Grupo31#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}