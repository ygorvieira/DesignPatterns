namespace AbstractFactory
{
    class Program
    {
        //Este padrão permite a criação de famílias de objetos relacionados ou dependentes por meio de uma única interface e sem que a classe concreta seja especificada.
        static void Main(string[] args)
        {
            IFabricaBases fabrica;
            Console.WriteLine("Escolha um dos personagens: 1-Protoss | 2-Zergs | 3-Terranos: ");

            switch(Console.ReadLine())
            {
                case "1": fabrica = new FabricaBaseProtoss();
                    break;
                case "2": fabrica = new FabricaBaseZerg();
                    break;
                case "3": fabrica = new FabricaBaseTerran();
                    break;
            }

            Console.ReadLine();
        }
    }
}