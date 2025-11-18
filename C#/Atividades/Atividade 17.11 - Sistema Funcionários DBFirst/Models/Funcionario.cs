using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_17._11___Sistema_Funcionários_DBFirst.Models
{
    public abstract class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal SalarioBase { get; set; }

        public string Cargo { get; set; } = string.Empty;

        public Funcionario() { }

        public Funcionario(string nomeConstrutor, decimal salarioBaseConstrutor)
        {
            Nome = nomeConstrutor;
            SalarioBase = salarioBaseConstrutor;
        }
        
        public abstract decimal CalcularSalario();
    }
}