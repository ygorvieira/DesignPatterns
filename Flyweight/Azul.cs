namespace Flyweight
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            this.condicao = " tartaruga fora do casco, ";
            this.acao = "voando - ";
        }

        public override void Mostra(string cor)
        {
            this.cor = cor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
