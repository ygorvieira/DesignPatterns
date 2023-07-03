namespace Composite
{
    public abstract class ComponenteFase
    {
        protected string nome;

        public ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase componenteFase);
        public abstract void Remover(ComponenteFase componenteFase);
        public abstract void Mostrar(int profundidade);
    }
}
