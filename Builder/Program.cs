namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permite a separação da construção de um objeto complexo da sua representação, de forma que o
            //mesmo processo de construção possa criar diferentes representações.
            var exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            criadorDeSoldado = new CriadorForcasEspeciais();
            exercito.ConstruirSoldado(criadorDeSoldado);

            soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);

            soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);
            Console.ReadKey();
        }
    }
}