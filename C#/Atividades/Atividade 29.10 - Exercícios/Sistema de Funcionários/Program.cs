namespace Sistema_de_Funcionários;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Sistema de Funcionários");
        Console.ForegroundColor = ConsoleColor.White;

        Funcionario vendedor = new Vendedor() { Nome = "João Souza", SalarioBase = 3000.00 };
        vendedor.ExibirResumo();
        Console.WriteLine($"Salário Calculado: {vendedor.CalcularSalario():F2}");

        Funcionario gerente = new Gerente() { Nome = "Ana Silva", SalarioBase = 4000.00 };
        gerente.ExibirResumo();
        Console.WriteLine($"Salário Calculado: {gerente.CalcularSalario():F2}");
    }
}
