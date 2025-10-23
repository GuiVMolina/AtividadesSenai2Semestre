namespace SubstituicaoLiskov
{
    public class Andorinha : Ave
    {
        public override void Mover() => Console.WriteLine("Voando...");
        public override void Dormir() => Console.WriteLine("Andorinha dormindo...");
    }
}