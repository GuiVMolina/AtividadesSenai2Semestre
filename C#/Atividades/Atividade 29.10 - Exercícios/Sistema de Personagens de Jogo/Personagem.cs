namespace Sistema_de_Personagens_de_Jogo
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nível { get; set; }
        public int Poder { get; set; }

        public abstract void CalcularPoder();

        public void ExibirStatus()
        {
            Console.WriteLine($"\nPersonagem Detalhes: "
                            + $"\nNome: {Nome}"
                            + $"\nNível: {Nível}");
        }
    }
}