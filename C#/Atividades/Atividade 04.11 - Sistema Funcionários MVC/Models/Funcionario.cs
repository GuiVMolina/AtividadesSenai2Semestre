using System.ComponentModel.DataAnnotations;

namespace Atividade_04._11___Sistema_Funcionários_MVC.Models
{
    public abstract class Funcionario
    {
        [Key] // Define a propriedade Id como chave primária
        public int Id { get; set; }

        [Required] // Define que o Nome é obrigatório
        public string Nome { get; set; } = string.Empty;

        [Range(0, 10000)] // Define um intervalo válido para o SalarioBase
        public decimal SalarioBase { get; set; }

        // Construtor padrão
        public Funcionario() { }

        // Construtor com parâmetros
        public Funcionario(string nome, decimal salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }
        
        public abstract double CalcularSalario();
    }
}