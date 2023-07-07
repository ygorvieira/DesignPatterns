namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um Facade é um objeto que provê uma interface simplificada para um corpo de código maior,
            //como por exemplo, uma biblioteca de classes.

            Facade facede = new Facade();

            facede.OperacaoA();
            facede.OperacaoB();

            Console.ReadKey();
        }
    }
}