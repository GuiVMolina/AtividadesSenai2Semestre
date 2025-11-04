namespace Sistema_de_Veículos
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }

        // Construtores
        public Veiculo() { }

        public Veiculo(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public abstract void CalcularRevisao();

        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nVeículo Detalhes: "
                            + $"\nModelo: {Modelo}"
                            + $"\nAno: {Ano}");
        }
    }
}