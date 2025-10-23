namespace SubstituicaoLiskov
{
    public abstract class Ave
    {
        public abstract void Mover();
        
        public void Dormir() => Console.WriteLine("Dormindo...");
    }
}