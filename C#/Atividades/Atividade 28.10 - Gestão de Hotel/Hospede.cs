namespace Atividade_28._10___Gestão_de_Hotel
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        // * Método construtor
        // Serve para inicializar os atributos da classe
        public Hospede(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void ExibirDetalhes()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Dados do Hóspede ===");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Nome: {Nome}"
                           + $"\nCPF: {CPF}"
                           + $"\nTelefone: {Telefone}");
        }
    }
}