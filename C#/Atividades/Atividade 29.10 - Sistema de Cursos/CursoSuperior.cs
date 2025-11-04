namespace Sistema_de_Cursos
{
    public class CursoSuperior : Curso
    {
        public override void CalcularPreco()
        {
            Valor = Horas * 40.0;
            Console.WriteLine($"Preço do curso superior {Nome}: R${Valor:F2}");
        }
    }
}