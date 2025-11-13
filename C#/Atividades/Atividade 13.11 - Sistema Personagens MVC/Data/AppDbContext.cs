using Microsoft.EntityFrameworkCore;
using Atividade_13._11___Sistema_Personagens_MVC.Models;

namespace Atividade_13._11___Sistema_Personagens_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }

        public DbSet<Personagem> TabelaPersonagem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>()
            .HasDiscriminator<string>("Classe")
            .HasValue<Guerreiro>("Guerreiro")
            .HasValue<Mago>("Mago");

            base.OnModelCreating(modelBuilder);
        }
    }
}