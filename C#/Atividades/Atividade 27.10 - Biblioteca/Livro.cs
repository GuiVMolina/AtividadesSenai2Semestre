namespace Atividade_27._10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        // {
        //     get
        //     {
        //         return AnoPublicacao;
        //     }
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             AnoPublicacao = value;
        //         }
        //         else
        //         {
        //             Console.WriteLine("Erro! Ano de publicação é inválido!");
        //         }
        //     }
        // }
        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; } = true;

        // CONSTRUTOR
        // É um método especial, usado para inicializar o estado do objeto
        public Livro(string tituloConstrutor,
                     string autorConstrutor,
                     int anoConstrutor,
                     double precoConstrutor)
        {
            // this.Titulo = titulo
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoConstrutor;
            Preco = precoConstrutor;

            // Definindo valor inicial como True
            EstaDisponivel = true;

            Console.WriteLine($"Novo livro: '{tituloConstrutor}' criado e disponível");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("*** DETALHES DO LIVRO ***"
                           + $"\nTitulo: {Titulo}"
                           + $"\nAutor: {Autor}"
                           + $"\nPublicação: {AnoPublicacao}"
                           + $"\nPreço: {Preco:F2}" // :F2 Fomrata com duas casas decimais
            );
            if (EstaDisponivel)
            {
                Console.WriteLine("Status: Disponível para Empréstimo");
            }
            else
            {
                Console.WriteLine("Status: Emprestado! (Indisponível)");
            }
        }

        public void Emprestar()
        {
            if (EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine($"O livro '{Titulo}' foi emprestado");
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' já está emprestado");
            }
        }
    }
}