namespace Adapter
{
    public class Aviao
    {
        public void Voar(string personagem)
        {
            Console.WriteLine(personagem + " VOOU PRA FRENTE!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil!");
        }
    }
}
