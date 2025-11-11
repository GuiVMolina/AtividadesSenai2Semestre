namespace Atividade_11._11___Sistema_Cursos_MVC.Models
{
    public class Superior : Curso
    {
        public Superior() { }

        public Superior(string nomeConstrutor, int horasConstrutor) :
        base(nomeConstrutor, horasConstrutor) { }
        
        public override double CalcularPreco() => Horas * 40.0;
    }
}