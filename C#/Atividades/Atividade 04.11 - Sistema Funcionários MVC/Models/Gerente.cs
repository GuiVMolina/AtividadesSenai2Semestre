namespace Atividade_04._11___Sistema_Funcionários_MVC.Models
{
    public class Gerente : Funcionario
    {
        public Gerente() { }

        public Gerente(string nome, double salario) :
        base(nome, salario) { }
        
        public override double CalcularSalario() => SalarioBase * 1.5;
    }
}