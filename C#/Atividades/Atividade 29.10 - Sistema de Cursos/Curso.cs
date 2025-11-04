namespace Sistema_de_Cursos
{
    public abstract class Curso
    {
        public string Nome { get; set; } = string.Empty;
        public int Horas { get; set; }
        public double Valor { get; set; }

        // Construtores
        public Curso() { }

        public Curso(string nome, int horas)
        {
            Nome = nome;
            Horas = horas;
        }

        public abstract void CalcularPreco();

        public void ExibirResumo()
        {
            Console.WriteLine($"\nCurso Detalhes: "
                            + $"\nNome: {Nome}"
                            + $"\nHoras: {Horas}");
        }
    }
}