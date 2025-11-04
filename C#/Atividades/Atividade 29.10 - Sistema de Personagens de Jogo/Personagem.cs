namespace Sistema_de_Personagens_de_Jogo
{
    public abstract class Personagem
    {
        public string Nome { get; set; } = string.Empty;
        public int Nível { get; set; }
        public int Poder { get; set; }

        // Construtores
        public Personagem() { }

        public Personagem(string nome, int nível)
        {
            Nome = nome;
            Nível = nível;
            Poder = 0;
        }

        public abstract void CalcularPoder();

        public void ExibirStatus()
        {
            Console.WriteLine($"\nPersonagem Detalhes: "
                            + $"\nNome: {Nome}"
                            + $"\nNível: {Nível}");
        }
    }
}