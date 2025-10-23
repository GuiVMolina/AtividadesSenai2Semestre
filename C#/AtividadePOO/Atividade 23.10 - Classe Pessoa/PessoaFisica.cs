namespace Atividade_23._10___Classe_Pessoa
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public override void PagarImposto() => Console.WriteLine($"Pessoa Física: {Nome}\nCPF: {CPF}\nPagando Imposto...");
    }
}