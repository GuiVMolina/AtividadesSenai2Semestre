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

        // * Reservas
        // Nome, Quarto, Tipo, PrecoDiaria
        Reserva normal = new Reserva("Ana Souza", 101, "Suíte", 1200);

        // Nome, Quarto, Tipo, Desconto, PrecoDiaria
        ReservaVip vip = new ReservaVip("Carlos Lima", 202, "Duplo", 10, 900);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=== Reserva Normal ===");
        Console.ForegroundColor = ConsoleColor.White;
        ana.ExibirDetalhes();
        normal.ExibirDetalhes();
        normal.ExibirInformacoes();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n=== Reserva VIP ===");
        Console.ForegroundColor = ConsoleColor.White;
        carlos.ExibirDetalhes();
        vip.ExibirDetalhes();
        vip.ExibirInformacoes();
    }
}
