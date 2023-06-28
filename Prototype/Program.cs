namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permite a criação de novos objetos a partir de um modelo original ou protótipo que é clonado.
            GerenciadorNuvens gerenciadorNuvens = new GerenciadorNuvens();

            gerenciadorNuvens["padrão"] = new NuvemConcreta("branco", "azul");

            gerenciadorNuvens["personalizada"] = new NuvemConcreta("branco", "laranja");

            NuvemConcreta um = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta dois = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;
            NuvemConcreta tres = gerenciadorNuvens["personalizada"].Clone() as NuvemConcreta;

            Console.ReadKey();
        }
    }
}