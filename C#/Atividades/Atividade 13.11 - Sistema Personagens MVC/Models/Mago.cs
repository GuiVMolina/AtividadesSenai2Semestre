namespace Atividade_13._11___Sistema_Personagens_MVC.Models
{
    public class Mago : Personagem
    {
        public Mago() { }

        public Mago(string nome, int nivel) :
        base(nome, nivel) { }

        public override int CalcularPoder() => Nivel * 8 + 20;
    }
}