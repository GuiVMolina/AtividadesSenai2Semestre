namespace Atividade_28._10___Gestão_de_Hotel
{
    public class Reserva
    {
        public string Hospede { get; set; }
        public int Quarto { get; set; }
        public int Dias { get; set; }
        public decimal PrecoDiaria { get; set; }
        public string Tipo { get; set; }

        public Reserva(string hospede, int quarto, string tipo, decimal precoDiaria)
        {
            Hospede = hospede;
            Quarto = quarto;
            Tipo = tipo;
            PrecoDiaria = precoDiaria;
            Dias = 1; // Valor padrão
        }

        public virtual void CalcularTotal()
        {
            decimal total = PrecoDiaria * Dias;
            Console.WriteLine($"Valor total da reserva: R$ {total:F2}");
        }

        public virtual void ExibirDetalhes()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== Detalhes da Reserva ===");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Hóspede: {Hospede}");
            Console.WriteLine($"Quarto: {Quarto}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Diária: R$ {PrecoDiaria:F2}");
            Console.WriteLine($"Dias: {Dias}");
        }

        public virtual void ExibirInformacoes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=== Resumo do Pagamento ===");
            Console.ForegroundColor = ConsoleColor.White;
            CalcularTotal();
            Console.WriteLine("===========================\n");
        }
    }
}