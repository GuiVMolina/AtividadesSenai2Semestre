namespace Atividade_27._10;

class Program
{
    static void Main(string[] args)
    {
        /*
        * SEM CONSTRUTOR
        Livro novoLivro = new Livro(); // Sem parâmetros

        Console.WriteLine($"Titulo: {novoLivro.Titulo}"
                        + $"\nAno: {novoLivro.AnoPublicacao}"
                        + $"\nDisponivel: {novoLivro.EstaDisponivel}"
        );

        * Colocando valores manualmente
        novoLivro.Titulo = "O Poder do Construtor";
        novoLivro.Autor = "Parceiro de Programação";
        novoLivro.AnoPublicacao = 2005;
        novoLivro.Preco = 59.90;
        novoLivro.EstaDisponivel = true;

        * Exibindo 
        Console.WriteLine("Exibindo detalhes: ");
        novoLivro.ExibirDetalhes();
        */

        //* COM CONSTRUTOR
        Console.WriteLine(">>> Sistema de controle de biblioteca <<<");

        //* Criando objeto novo com construtor
        Livro livro1 = new Livro("A Arte da Guerra", "Sun Tzu", 1950, 45.90);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899, 30.50);

        //* Interação com os livros - Emprestar / Ver Detalhes
        // Livro 1
        Console.WriteLine("Livro 1:");
        livro1.ExibirDetalhes();
        livro1.Emprestar();
        livro1.ExibirDetalhes();
        livro1.Emprestar();

        // Livro 2
        Console.WriteLine("Livro 2:");
        livro2.ExibirDetalhes();
        livro2.Preco = 32.99;
        Console.WriteLine($"Atualização de preço: '{livro2.Titulo}' ajustado para R${livro2.Preco:F2}");
        livro2.ExibirDetalhes();
    }
}