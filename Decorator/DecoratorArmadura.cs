namespace Decorator
{
    public class DecoratorArmadura : MoldeArmadura
    {
        string _descricao = "Decorator Abstrato da Armadura do Personagem";

        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
