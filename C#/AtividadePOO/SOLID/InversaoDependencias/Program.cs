namespace InversaoDependencias;

class Program
{
    static void Main(string[] args)
    {
        IDispositivo lampada = new Lampada();
        IDispositivo ar = new ArCondicionado();

        Interruptor interruptor = new Interruptor(lampada);
        Interruptor interruptor2 = new Interruptor(ar);
        interruptor.Acionar();
        interruptor2.Acionar();
    }
}
