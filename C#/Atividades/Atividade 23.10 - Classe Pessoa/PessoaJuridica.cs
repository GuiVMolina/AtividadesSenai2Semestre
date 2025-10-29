namespace Atividade_23._10___Classe_Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public override void PagarImposto() => Console.WriteLine($"Pessoa Jurídica: {Nome}\nCNPJ: {CNPJ}\nPagando Imposto...");
    }
}