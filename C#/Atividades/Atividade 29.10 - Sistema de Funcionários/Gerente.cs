namespace Sistema_de_Funcionários
{
    public class Gerente : Funcionario
    {
        public Gerente (string nome, double salarioBase) :
        base(nome, salarioBase) { }
        public override double CalcularSalario()
        {
            return SalarioBase * 1.5; // Bônus de 50% a mais sobre o salário base
        }
    }
}