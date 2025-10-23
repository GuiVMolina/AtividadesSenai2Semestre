namespace ResponsabilidadeUnica;

class Program
{
    static void Main(string[] args)
    {
        Relatorio rel = new Relatorio();
        Enviador env = new Enviador();

        rel.GerarRelatorio();
        env.EnviarEmail();
    }
}