namespace Sistema_de_Animais;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Sistema de Animais");
        Console.ForegroundColor = ConsoleColor.White;

        Animal leao = new Leao() { Nome = "Leão" };
        Console.WriteLine($"\nAnimal: {leao.Nome}");
        leao.EmitirSom();
        leao.TipoAlimentacao();

        Animal elefante = new Elefante() { Nome = "Elefante" };
        Console.WriteLine($"\nAnimal: {elefante.Nome}");
        elefante.EmitirSom();
        elefante.TipoAlimentacao();
    }
}
