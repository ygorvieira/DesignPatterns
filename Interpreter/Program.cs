using Interpreter;

//Define uma representação para sua gramática juntamente com um interpretador
//que usa a representação para interpretar sentenças na língua. 

Mochila mochila = new Mochila(new Corda(), new Binoculos(), new ArcoFlecha());

mochila.Interpretar(new Contexto());

Console.ReadKey();