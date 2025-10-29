namespace Atividade_28._10___Gestão_de_Hotel
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string? Tipo { get; set; }
        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; }

        public Quarto(int numero, string tipo, double precoDiaria)
        {
            Numero = numero;
            Tipo = tipo;
            PrecoDiaria = precoDiaria;
            Disponivel = true; // Inicialmente, o quarto está disponível
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Número: {Numero}"
                            + $"Tipo: {Tipo}"
                            + $"Preço da Diária: {PrecoDiaria}"
                            + $"Disponivel: {(Disponivel ? "Ocupado" : "Liberado")}");
        }

        public void Ocupar()
        {
            if (!Disponivel)
            {
                Console.WriteLine("Esse quarto já está ocupado!");
            }
            else
            {
                Disponivel = false;
                Console.WriteLine("Quarto ocupado com sucesso.");
            }
        }
        public void Liberar()
        {
            if (Disponivel)
            {
                Console.WriteLine("Esse quarto já está liberado!");
            }
            else
            {
                Disponivel = true;
                Console.WriteLine("Quarto liberado com sucesso.");
            }
        }
    }
}