namespace Atividade2_ClasseAbstrata
{
    public class Circulo : Forma
    {
        public double Raio;
        public override double CalcularArea() => Math.PI * Raio * Raio;
    }
}