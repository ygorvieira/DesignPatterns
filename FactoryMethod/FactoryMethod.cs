using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        //A Factory delega a responsabilidade para que as subclasses especifiquem seu tipo.
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "Sub Zero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
