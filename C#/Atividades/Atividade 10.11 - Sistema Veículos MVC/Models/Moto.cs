namespace Atividade_10._11___Sistema_Veiculos_MVC.Models
{
    public class Moto : Veiculo
    {
        public Moto() { }
        public Moto(string modelo, string nome, int ano, double preco) :
        base(modelo, nome, ano, preco) { }
        public override double CalcularValor() => Preco + 300.0;
    }
}