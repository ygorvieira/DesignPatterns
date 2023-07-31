namespace Observer
{
    public class Inimigo : IObservador
    {
        private Cody personagemObservado;

        public void Avisar(IPersonagem personagem)
        {
            if (personagemObservado == personagemObservado)
            {
                Console.WriteLine("Cody foi atingido com um golpe. Sua vida é de: " + personagemObservado.GetVida());
            }
        }

        public Inimigo(Cody cody)
        {
            personagemObservado = cody;
            personagemObservado.RegistrarObservador(this);
        }
    }
}
