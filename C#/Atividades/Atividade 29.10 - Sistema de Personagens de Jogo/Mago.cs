namespace Sistema_de_Personagens_de_Jogo
{
    public class Mago : Personagem
    {
        public override void CalcularPoder()
        {
            Poder = Nível * 8 + 20;
            Console.WriteLine($"Poder do mago {Nome}: {Poder}");
        }
    }
}