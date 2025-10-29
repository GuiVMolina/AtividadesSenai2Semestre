namespace Sistema_de_Funcionários
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public abstract double CalcularSalario();

        public void ExibirResumo()
        {
            Console.WriteLine($"\nFuncionário Detalhes: "
                            + $"\nNome: {Nome}"
                            + $"\nSalário Base: {SalarioBase:F2}");
        }
    }
}