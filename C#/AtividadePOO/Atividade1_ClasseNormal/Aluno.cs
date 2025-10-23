namespace AtividadePOO
{
    //* Herança = Aluno herda as características da classe Pessoa (Aluno : Pessoa)
    // Isso permite a classe Aluno agora possuir os mesmos atributos de Pessoa
    public class Aluno : Pessoa
    {
        public string Curso;
        
        //* override = A função será sobrescrita
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o(a) aluno(a) {Nome}, tenho {Idade} anos e estudo {Curso}");
        }
    }
}