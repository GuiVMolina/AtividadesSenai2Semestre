namespace AtividadePOO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Estruturação da Programação Orientada à Objetos (POO)");

        // Definindo uma Pessoa (p)
        Pessoa p = new Pessoa
        {
            Nome = "Késsia",
            Idade = 26
        };

        // Definindo um Aluno (a)
        Aluno a = new Aluno
        {
            Nome = "Guilherme",
            Idade = 19,
            Curso = "Desenvolvimento de Sistemas"
        };

        // Chamando o método Apresentar() de cada Classe
        p.Apresentar();
        a.Apresentar();
    }
}