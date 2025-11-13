namespace Atividade_13._11___Sistema_Animais_MVC.Models
{
    public class Leao : Animal
    {
        public Leao() { }

        public Leao(string nomeConstrutor) :
        base(nomeConstrutor) { }

        public override string EmitirSom() => "Rugido";
        public override string TipoAlimentacao() => "Carnívoro";
    }
}