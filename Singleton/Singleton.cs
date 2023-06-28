using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        //Este padrão garante a existência de apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto.
        private static Singleton instancia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em jogo");
                }
                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
