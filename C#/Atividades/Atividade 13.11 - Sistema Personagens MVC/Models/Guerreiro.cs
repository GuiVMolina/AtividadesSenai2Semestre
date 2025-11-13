namespace Atividade_13._11___Sistema_Personagens_MVC.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() { }

        public Guerreiro(string nome, int nivel) :
        base(nome, nivel) { }

        public override int CalcularPoder() => Nivel * 10;
    }
}