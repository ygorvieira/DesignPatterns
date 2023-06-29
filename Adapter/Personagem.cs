namespace Adapter
{
    public class Personagem : IAcao
    {
        public void Andar(string jogador)
        {
            Console.WriteLine(jogador + " ANDOU PRA FRENTE!");
        }

        public void Atirar()
        {
            Console.WriteLine("Atirou!");
        }
    }
}
