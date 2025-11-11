using System.ComponentModel.DataAnnotations;

namespace Atividade_10._11___Sistema_Veiculos_MVC.Models
{
    public abstract class Veiculo
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public int Ano { get; set; }
        public double Preco { get; set; }

        public Veiculo() { }

        public Veiculo(string modeloConstrutor, string nomeConstrutor, int anoConstrutor, double precoConstrutor)
        {
            Modelo = modeloConstrutor;
            Nome = nomeConstrutor;
            Ano = anoConstrutor;
            Preco = precoConstrutor;
        }

        public abstract double CalcularValor();
    }
}