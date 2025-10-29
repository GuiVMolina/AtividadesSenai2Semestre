namespace Sistema_de_Funcionários
{
    public class Vendedor : Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase * 1.2; // Bônus de 20% a mais sobre o salário base
        }
    }
}