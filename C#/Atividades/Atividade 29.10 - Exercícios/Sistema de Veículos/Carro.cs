namespace Sistema_de_Veículos
{
    public class Carro : Veiculo
    {
        public double Preco { get; set; } = 500.00;
        public override void CalcularRevisao()
        {
            Console.WriteLine($"Revisão de custo do carro: {Preco:F2}");
        }
    }
}