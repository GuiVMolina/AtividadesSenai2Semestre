namespace Sistema_de_Veículos
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public abstract void CalcularRevisao();

        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nVeículo Detalhes: "
                            + $"\nModelo: {Modelo}"
                            + $"\nAno: {Ano}");
        }
    }
}