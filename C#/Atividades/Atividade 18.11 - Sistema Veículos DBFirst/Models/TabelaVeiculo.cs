using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atividade_18._11___Sistema_Veículos_DBFirst.Models;

[Table("TabelaVeiculo")]
public partial class TabelaVeiculo
{
    [Key]
    public int Id { get; set; }

    [StringLength(8)]
    public string Modelo { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public int Ano { get; set; }

    public double Preco { get; set; }
}
