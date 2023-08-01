using Visitor;

//Permite que se crie uma nova operação sem que se mude a classe dos elementos
//sobre as quais ela opera.
//É uma maneira de separar um algoritmo da estrutura de um objeto.

List<IJogo> jogo = new List<IJogo>();

jogo.Add(new FaseJogo() { NomeFase = "Floresta"});
jogo.Add(new FaseJogo() { NomeFase = "Caverna" });
jogo.Add(new Chefao() { NomeChefao = "Boss 1", PontosVida = 30 });
jogo.Add(new Chefao() { NomeChefao = "Boss 2", PontosVida = 50 });

NivelVisitor niveis = new NivelVisitor();

foreach (var etapa in jogo)
{
    etapa.Visitante(niveis);
}

Console.ReadLine();