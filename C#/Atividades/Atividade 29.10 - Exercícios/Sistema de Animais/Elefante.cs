namespace Sistema_de_Animais
{
    public class Elefante : Animal
    {
        public override void EmitirSom() => Console.WriteLine("Som: Barrito");
        public override void TipoAlimentacao() => Console.WriteLine("Alimentação: Herbívoro");
    }
}