namespace SubstituicaoLiskov
{
    public class Pinguim : Ave
    {
        public override void Mover() => Console.WriteLine("Andando...");
        public override void Dormir() => Console.WriteLine("Pinguim dormindo...");
    }
}