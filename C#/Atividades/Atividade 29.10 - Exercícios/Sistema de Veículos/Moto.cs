namespace Sistema_de_Veículos
{
    public class Moto : Veiculo
    {
        public double Preco { get; set; } = 300.00;
        public override void CalcularRevisao()
        {
            Console.WriteLine($"Revisão de custo da moto: {Preco:F2}");
        }
    }
}