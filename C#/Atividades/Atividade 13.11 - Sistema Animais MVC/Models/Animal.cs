using System.ComponentModel.DataAnnotations;

namespace Atividade_13._11___Sistema_Animais_MVC.Models
{
    public abstract class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public Animal() { }
        public Animal(string nomeConstrutor)
        {
            Nome = nomeConstrutor;
        }

        public abstract string EmitirSom();
        public abstract string TipoAlimentacao();
    }
}