namespace Builder
{
    public class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais();
        }
        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }

        public override void Transporte()
        {
            _soldado.DefinirFoco("Combate em solo");
        }
    }
}
