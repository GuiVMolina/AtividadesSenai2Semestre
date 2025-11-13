using Microsoft.EntityFrameworkCore;
using Atividade_13._11___Sistema_Animais_MVC.Models;

namespace Atividade_13._11___Sistema_Animais_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }

        public DbSet<Animal> TabelaAnimal { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
            .HasDiscriminator<string>("TipoAnimal")
            .HasValue<Leao>("Leao")
            .HasValue<Elefante>("Elefante");

            base.OnModelCreating(modelBuilder);
        }
    }
}