namespace Atividade_28._10___Gestão_de_Hotel;

class Program
{
    static void Main(string[] args)
    {
        // Console.ForegroundColor define a cor do texto no console
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Bem-vindo ao Hotel Pôr-do-sol!");
        Console.ForegroundColor = ConsoleColor.White;

        // * Hóspedes
        // Nome, CPF, Telefone
        Hospede ana = new Hospede("Ana Souza", "111.111.111-11", "(11) 11111-1111");
        
        // Nome, CPF, Telefone
        Hospede carlos = new Hospede("Carlos Lima", "222.222.222-22", "(22) 22222-2222");

        // * Quartos
        Quarto quartoSuite = new Quarto(101, "Suíte", 1200);
        Quarto quartoDuplo = new Quarto(202, "Duplo", 900);

        // * Reservas
        // Hospede, Quarto, Dias, ValorTotal (será calculado pelo método)
        Reserva normal = new Reserva(ana, quartoSuite, 3, 0);

        // Hospede, Quarto, Dias, Desconto, ValorTotal (será calculado pelo método)
        ReservaVip vip = new ReservaVip(carlos, quartoDuplo, 5, 10, 0);

        List<Reserva> reservas = new List<Reserva> { normal, vip };
        List<Hospede> hospedes = new List<Hospede> { ana, carlos };
        foreach (var hospede in hospedes)
        {
            hospede.ExibirHospede();
        }
        foreach (var reserva in reservas)
        {
            reserva.ExibirDetalhes();
        }
    }
}
