namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica");
        }
    }
}