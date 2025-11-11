namespace Atividade_10._11___Sistema_Veiculos_MVC.Models
{
    public class Carro : Veiculo
    {
        public Carro() { }
        public Carro(string modelo, string nome, int ano, double preco) :
        base(modelo, nome, ano, preco) { }
        public override double CalcularValor() => Preco + 500.0;
    }
}