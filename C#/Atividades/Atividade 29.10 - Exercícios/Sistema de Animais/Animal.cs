namespace Sistema_de_Animais
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract void EmitirSom();
        public abstract void TipoAlimentacao();
    }
}