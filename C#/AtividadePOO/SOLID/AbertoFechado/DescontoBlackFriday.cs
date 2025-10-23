namespace AbertoFechado
{
    public class DescontoBlackFriday : Desconto
    {
        public override double Calcular(double valor) => valor * 0.20;
    }
}