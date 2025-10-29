namespace Sistema_de_Veículos;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sistema de Veículos");
        Console.ForegroundColor = ConsoleColor.White;

        Carro carro = new Carro() { Modelo = "Honda CG 160", Ano = 2020 };
        carro.ExibirDetalhes();
        carro.CalcularRevisao();

        Moto moto = new Moto() { Modelo = "Yamaha YZF-R3", Ano = 2021 };
        moto.ExibirDetalhes();
        moto.CalcularRevisao();
    }
}
