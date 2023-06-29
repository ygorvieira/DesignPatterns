namespace Flyweight
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = " tartaruga fora do casco, ";
            this.acao = "andando - ";
        }

        public override void Mostra(string cor)
        {
            this.cor = cor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
