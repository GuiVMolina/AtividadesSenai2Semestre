using Microsoft.EntityFrameworkCore;
using Atividade_04._11___Sistema_Funcionários_MVC.Models;

namespace Atividade_04._11___Sistema_Funcionários_MVC.Data
{
    public class AppDbContext : DbContext
    {
        // Recebe as opções de configuração do banco
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }

        // Direciona a classe (Funcionario) para a tabela (TabelaFuncionario)
        public DbSet<Funcionario> TabelaFuncionario { get; set; }

        // Vai sobreescrever o mapeamento do modelo
        // (Uma única tabela para funcionários)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar entidade base Funcionario
            modelBuilder.Entity<Funcionario>()
            // Cria uma única tabela, diferenciando Gerente e Vendedor por cargo
            .HasDiscriminator<string>("Cargo")
            // Quando a instância for Gerente, grava "Gerente" em cargo
            .HasValue<Gerente>("Gerente")
            // Quando a instância for Vendedor, grava "Vendedor" em cargo
            .HasValue<Vendedor>("Vendedor");

            base.OnModelCreating(modelBuilder);
        }
    }
}