namespace Atividade_28._10___Gestão_de_Hotel
{
    public class ReservaVip : Reserva
    {
        public int Desconto { get; set; }
        public ReservaVip(Hospede hospede, Quarto quarto, int dias, int desconto, double valorTotal)
            : base(hospede, quarto, dias, valorTotal)
        {
            Desconto = desconto;
        }

        public override double CalcularTotal()
        {
            double ValorSemDesconto = QuartoReserva.PrecoDiaria * Dias;
            double valorComDesconto = ValorSemDesconto * (1 - (Desconto / 100.0));
            Console.WriteLine($"Valor total da reserva (com {Desconto}% de desconto): R${valorComDesconto:F2}");
            return valorComDesconto;
        }

        public override void ExibirDetalhes()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n======= Detalhes da Reserva VIP =======");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Hóspede: {HospedeReserva.Nome}"
                            + $"\nTipo: {QuartoReserva.Tipo}"
                            + $"\nQuarto: {QuartoReserva.Numero}"
                            + $"\nDias: {Dias}"
                            + $"\nDiária: R${QuartoReserva.PrecoDiaria:F2}"
                            + $"\nDesconto: {Desconto}%");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n------- Resumo do Pagamento -------");
            Console.ForegroundColor = ConsoleColor.White;
            CalcularTotal();
            Console.WriteLine("=====================================\n");
        }
    }
}