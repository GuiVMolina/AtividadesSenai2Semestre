using System.ComponentModel.DataAnnotations;

namespace Atividade_13._11___Sistema_Personagens_MVC.Models
{
    public abstract class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public int Nivel { get; set; }

        public Personagem() { }

        public Personagem(string nomeConstrutor, int nivelConstrutor)
        {
            Nome = nomeConstrutor;
            Nivel = nivelConstrutor;
        }

        public abstract int CalcularPoder();
    }
}