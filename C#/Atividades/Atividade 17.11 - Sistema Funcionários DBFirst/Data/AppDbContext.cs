using System;
using System.Collections.Generic;
using Atividade_17._11___Sistema_Funcionários_DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_17._11___Sistema_Funcionários_DBFirst.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }
    public virtual DbSet<Gerente> Gerentes { get; set; }
    public virtual DbSet<Vendedor> Vendedores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Funcionario>()
            .ToTable("TabelaFuncionario")
            .HasDiscriminator<string>("Cargo")
            .HasValue<Gerente>("Gerente")
            .HasValue<Vendedor>("Vendedor");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
