namespace Sistema_de_Cursos
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double Valor { get; set; }

        public abstract void CalcularPreco();
        public void ExibirResumo()
        {
            Console.WriteLine($"\nCurso Detalhes: "
                            + $"\nNome: {Nome}"
                            + $"\nHoras: {Horas}");
        }
    }
}