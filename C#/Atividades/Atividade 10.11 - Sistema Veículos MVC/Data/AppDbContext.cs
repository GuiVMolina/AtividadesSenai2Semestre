using Microsoft.EntityFrameworkCore;
using Atividade_10._11___Sistema_Veiculos_MVC.Models;

namespace Atividade_10._11___Sistema_Veiculos_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }
        public DbSet<Veiculo> TabelaVeiculo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
            .HasDiscriminator<string>("Modelo")
            .HasValue<Carro>("Carro")
            .HasValue<Moto>("Moto");
            base.OnModelCreating(modelBuilder);
        }
    }
}