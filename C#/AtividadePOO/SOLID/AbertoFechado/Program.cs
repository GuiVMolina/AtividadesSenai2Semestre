namespace AbertoFechado;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();

        // :C traz o formato monetário conforme o sistema
        Console.WriteLine($"Desconto de Natal: {d1.Calcular(1000):C}");
        Console.WriteLine($"Desconto de Black Friday: {d2.Calcular(1000):C}");
        // Console.WriteLine($"Desconto de Black Friday: {d2.Calcular(1000).ToString("C")}");
    }
}
