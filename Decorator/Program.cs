namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permite adicionar um comportamento a um objeto já existente em tempo de execução,
            //ou seja, agrega dinamicamente responsabilidades adicionais a um objeto.

            Console.WriteLine(" ### Veste Armadura Padão ###");
            MoldeArmadura armadura = new ArmaduraPadrao();

            Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));

            Console.WriteLine();

            Console.WriteLine(" ### Incluir Novos Itens na Armadura (Decorar) ###");
            armadura = new Capacete(armadura);
            armadura = new Espada(armadura);

            Console.WriteLine("Descrição: " + armadura.Descricao.TrimEnd(' ', ','));
            Console.ReadKey();
        }
    }
}