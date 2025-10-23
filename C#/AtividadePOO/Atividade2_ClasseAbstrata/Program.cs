namespace Atividade2_ClasseAbstrata;

class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo() { Largura = 5, Altura = 3 };
        Circulo c = new Circulo() { Raio = 3 };

        r.MostrarTipo();
        Console.WriteLine($"Área do Retângulo: {r.CalcularArea()}");

        c.MostrarTipo();
        Console.WriteLine($"Área do Círculo: {c.CalcularArea()}");
    }
}
