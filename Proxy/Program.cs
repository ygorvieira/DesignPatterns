namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um Proxy, em sua forma mais geral, é uma classe que funciona como uma interface para outra coisa.

            ProxyFase proxy = new ProxyFase();

            Console.WriteLine("#### Tentando acessar a fase do jogo com Password incorreto ####");

            Console.WriteLine(proxy.InformarPassword("batata"));

            Console.WriteLine(proxy.Jogar());

            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jogo com Password correto ####");

            Console.WriteLine(proxy.InformarPassword("IDDQD"));

            Console.WriteLine(proxy.Jogar());

            Console.WriteLine();

            //Console.WriteLine("#### Usando o Proxy para controlar o acesso à fase do jogo ####");

            //Console.WriteLine();

            //ProxyFase proxy = new ProxyFase();

            //Console.WriteLine(proxy.Jogar());

            //Console.ReadKey();


            //Console.WriteLine("#### Acessando a Fase do Jogo sem o Proxy ####");

            //FaseJogo fase = new FaseJogo();

            //Console.WriteLine(fase.Jogar());
            //Console.WriteLine();

            //Console.ReadKey();
        }
    }
}