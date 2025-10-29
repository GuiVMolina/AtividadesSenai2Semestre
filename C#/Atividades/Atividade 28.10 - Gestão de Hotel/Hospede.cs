namespace Atividade_28._10___Gestão_de_Hotel
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Hospede(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("\n=== Dados do Hóspede ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine("========================\n");
        }
    }
}