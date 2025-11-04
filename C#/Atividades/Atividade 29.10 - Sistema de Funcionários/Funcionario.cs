namespace Sistema_de_Funcionários
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public double SalarioBase { get; set; }

        // Construtores
        public Funcionario() { }

        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularSalario();

        public void ExibirResumo()
        {
            Console.WriteLine($"\nFuncionário Detalhes: "
                            + $"\nNome: {Nome}"
                            + $"\nSalário Base: {SalarioBase:F2}");
        }
    }
}