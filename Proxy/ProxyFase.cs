namespace Proxy
{
    public class ProxyFase : IFase
    {
        FaseJogo fasejogo;
        string password = "IDDQD";

        public string Jogar()
        {
            if(this.fasejogo != null)
                return fasejogo.Jogar();

            return "Informe o PASSWORD correto para abrir a fase do jogo!";
        }

        public string InformarPassword(string codigo)
        {
            if(codigo == this.password)
            {
                this.fasejogo = new FaseJogo();
                return "Passord correto!";
            }
            return "Password incorreto!";
        }
    }
}
