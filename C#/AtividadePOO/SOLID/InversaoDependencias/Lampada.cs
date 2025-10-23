namespace InversaoDependencias
{
    public class Lampada : IDispositivo
    {
        public void Ligar() => Console.WriteLine("Lâmpada ligada!");
    }
}