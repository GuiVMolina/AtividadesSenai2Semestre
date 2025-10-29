namespace Sistema_de_Cursos;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Sistema de Cursos");
        Console.ForegroundColor = ConsoleColor.White;

        Curso tecnico = new CursoTecnico() { Nome = "Técnico em Informática", Horas = 1200 };
        tecnico.ExibirResumo();
        tecnico.CalcularPreco();

        Curso superior = new CursoSuperior() { Nome = "Bacharelado em Sistemas de Informação", Horas = 3200 };
        superior.ExibirResumo();
        superior.CalcularPreco();
    }
}
