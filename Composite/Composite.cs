namespace Composite
{
    public class Composite : ComponenteFase
    {
        private List<ComponenteFase> fasesjogo = new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {
            
        }
        public override void Adicionar(ComponenteFase componenteFase)
        {
            this.fasesjogo.Add(componenteFase);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach (ComponenteFase item in this.fasesjogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase componenteFase)
        {
            this.fasesjogo.Remove(componenteFase);
        }
    }
}
