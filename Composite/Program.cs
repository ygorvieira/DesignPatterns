namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizado para representar um objeto formado pela composição de objetos similares.
            //Este conjunto de objetos pressupõe uma mesma hierarquia de classes a que ele pertence.

            Composite mapa = new Composite("MAPA DAS CAVERNAS");

            Composite caverna1 = new Composite("Caverna 1");
            caverna1.Adicionar(new FaseJogo("Subfase 1"));
            caverna1.Adicionar(new FaseJogo("Subfase 2"));
            caverna1.Adicionar(new FaseJogo("Subfase 3"));

            Composite caverna2 = new Composite("Caverna 2");
            caverna2.Adicionar(new FaseJogo("Subfase 4"));
            caverna2.Adicionar(new FaseJogo("Subfase 5"));

            Composite porta_secreta = new Composite("Porta Secreta");
            porta_secreta.Adicionar(new FaseJogo("Subfase Secreta X"));

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);

            caverna2.Adicionar(porta_secreta);

            mapa.Mostrar(1);

            Console.ReadKey();
        }
    }
}