using System;
using System.Collections.Generic;
using Atividade_18._11___Sistema_Veículos_DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_18._11___Sistema_Veículos_DBFirst.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TabelaVeiculo> TabelaVeiculos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
