namespace Sistema_de_Personagens_de_Jogo;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Sistema de Personagens de Jogo");
        Console.ForegroundColor = ConsoleColor.White;

        Guerreiro guerreiro = new Guerreiro() { Nome = "Saber", Nível = 10 };
        guerreiro.ExibirStatus();
        guerreiro.CalcularPoder();

        Mago mago = new Mago() { Nome = "Caster", Nível = 9 };
        mago.ExibirStatus();
        mago.CalcularPoder();
    }
}
