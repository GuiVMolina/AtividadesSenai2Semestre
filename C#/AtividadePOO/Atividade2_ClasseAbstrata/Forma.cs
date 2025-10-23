namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        // Método abstrato obriga a classe filha a implementar
        // o método e sobreescreve-lo //* (override)
        public abstract double CalcularArea();
        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica");
        }
    }
}