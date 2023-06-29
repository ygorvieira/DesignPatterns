namespace Flyweight
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Usado quando vários objetos devem ser manipulados em memória sendo que muitos deles possuem informações repetidas.
            Flyweight flyweight = new Flyweight();
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Qual tartaruga enviar para tela?: ");
                cor = Console.ReadLine();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor); 
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }
    }
}