namespace Sistema_de_Personagens_de_Jogo
{
    public class Guerreiro : Personagem
    {
        public override void CalcularPoder()
        {
            Poder = Nível * 10;
            Console.WriteLine($"Poder do guerreiro {Nome}: {Poder}");
        }
    }
}