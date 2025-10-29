namespace Sistema_de_Funcionários
{
    public class Gerente : Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase * 1.5; // Bônus de 50% a mais sobre o salário base
        }
    }
}