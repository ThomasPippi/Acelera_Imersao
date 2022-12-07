using EstudandoRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudandoRestAPI.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }


        public Contexto()
        {
            //Add-Migration Initial
            //Update-Database
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=localhost;Port=5432;User ID=postgres;password=91504759;database=API");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
