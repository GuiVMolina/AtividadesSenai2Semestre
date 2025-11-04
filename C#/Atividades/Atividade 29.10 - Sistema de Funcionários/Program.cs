namespace Sistema_de_Funcionários;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Sistema de Funcionários");
        Console.ForegroundColor = ConsoleColor.White;

        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente("Ana Silva", 4000.00),
            new Vendedor("João Souza", 3000.00)
        };

        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirResumo();
            Console.WriteLine($"Salário Calculado: {funcionario.CalcularSalario():F2}");
        }
    }
}
