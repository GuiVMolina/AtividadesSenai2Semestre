namespace Sistema_de_Animais
{
    public abstract class Animal
    {
        public string Nome { get; set; } = string.Empty;

        // Construtores
        public Animal() { }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public abstract void EmitirSom();
        public abstract void TipoAlimentacao();
    }
}