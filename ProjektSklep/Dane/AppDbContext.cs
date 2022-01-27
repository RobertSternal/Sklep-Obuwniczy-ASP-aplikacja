using Microsoft.EntityFrameworkCore;
using ProjektSklep.Models;


namespace ProjektSklep.Dane
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Kolorystyka> Kolorystyki { get; set; }
        public DbSet<But> Buty { get; set; }
        public DbSet<Producent> Producenci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kolorystyka>().ToTable("Kolorystyki");
            modelBuilder.Entity<But>().ToTable("Buty");
            modelBuilder.Entity<Producent>().ToTable("Producenci");

        }


    }
}
