using System.Text.Encodings.Web;

namespace Atividade_28._10___Gestão_de_Hotel
{
    public class ReservaVip : Reserva
    {
        public int Desconto { get; set; }

        public ReservaVip(string hospede, int quarto, string tipo, int desconto, decimal precoDiaria) 
            : base(hospede, quarto, tipo, precoDiaria)
        {
            Desconto = desconto;
        }

        public override void CalcularTotal()
        {
            decimal total = (PrecoDiaria * Dias) * ((100 - Desconto) / 100m);
            Console.WriteLine($"Valor total da reserva (com {Desconto}% de desconto): R$ {total:F2}");
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Desconto: {Desconto}%");
        }
    }
}