namespace Atividade_11._11___Sistema_Cursos_MVC.Models
{
    public class Tecnico : Curso
    {
        public Tecnico() { }

        public Tecnico(string nomeConstrutor, int horasConstrutor) :
        base(nomeConstrutor, horasConstrutor) { }
        
        public override double CalcularPreco() => Horas * 20.0;
    }
}