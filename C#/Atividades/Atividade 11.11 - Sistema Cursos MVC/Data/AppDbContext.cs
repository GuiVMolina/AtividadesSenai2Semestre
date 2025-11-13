using Microsoft.EntityFrameworkCore;
using Atividade_11._11___Sistema_Cursos_MVC.Models;

namespace Atividade_11._11___Sistema_Cursos_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
        { }
        public DbSet<Curso> TabelaCurso { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Tecnico>("Tecnico")
            .HasValue<Superior>("Superior");
            base.OnModelCreating(modelBuilder);
        }
    }
}