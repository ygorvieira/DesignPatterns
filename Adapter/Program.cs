namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converte a interface de uma classe para outra interface que o cliente espera encontrar,
            //"traduzindo" solicitações do formato requerido pelo usuário para o formato compatível
            //com o a classe adaptee e as redirecionando.

            Personagem ygor = new Personagem();

            Aviao aviao_de_batalha = new Aviao();

            IAcao adaptador = new Adapter(aviao_de_batalha);

            Console.WriteLine("--- CAMINHANDO ---");
            ygor.Andar("Ygor");
            ygor.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM AVIÃO ---");
            adaptador.Andar("Ygor");
            adaptador.Atirar();

            Console.ReadKey();
        }
    }
}