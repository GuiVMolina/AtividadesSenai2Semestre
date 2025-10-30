namespace Atividade_28._10___Gestão_de_Hotel
{
    public class Reserva
    {
        public Hospede HospedeReserva { get; set; }
        public Quarto QuartoReserva { get; set; }
        public int Dias { get; set; }
        public double ValorTotal { get; set; }

        public Reserva(Hospede hospede, Quarto quarto, int dias, double valorTotal)
        {
            HospedeReserva = hospede;
            QuartoReserva = quarto;
            Dias = dias;
            ValorTotal = valorTotal;
        }

        public virtual double CalcularTotal()
        {
            ValorTotal = QuartoReserva.PrecoDiaria * Dias;
            Console.WriteLine($"Valor total da reserva: R$ {ValorTotal:F2}");
            return ValorTotal;
        }

        public virtual void ExibirDetalhes()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n======= Detalhes da Reserva =======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Hóspede: {HospedeReserva.Nome}"
                            + $"\nTipo: {QuartoReserva.Tipo}"
                            + $"\nQuarto: {QuartoReserva.Numero}"
                            + $"\nDias: {Dias}"
                            + $"\nDiária: R${QuartoReserva.PrecoDiaria:F2}");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n------- Resumo do Pagamento -------");
            Console.ForegroundColor = ConsoleColor.White;
            CalcularTotal();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}