namespace Sistema_de_Animais
{
    public class Leao : Animal
    {
        public override void EmitirSom() => Console.WriteLine("Som: Rugido");
        public override void TipoAlimentacao() => Console.WriteLine("Alimentação: Carnívoro");
    }
}