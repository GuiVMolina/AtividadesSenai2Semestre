namespace Atividade_13._11___Sistema_Animais_MVC.Models
{
    public class Elefante : Animal
    {
        public Elefante() { }

        public Elefante(string nomeConstrutor) :
        base(nomeConstrutor) { }

        public override string EmitirSom() => "Trombeteio";
        public override string TipoAlimentacao() => "Herbívoro";
    }
}