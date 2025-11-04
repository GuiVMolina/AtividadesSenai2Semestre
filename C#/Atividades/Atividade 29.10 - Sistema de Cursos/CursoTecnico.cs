namespace Sistema_de_Cursos
{
    public class CursoTecnico : Curso
    {
        public override void CalcularPreco()
        {
            Valor = Horas * 20.0;
            Console.WriteLine($"Preço do curso técnico {Nome}: R${Valor:F2}");
        }
    }
}