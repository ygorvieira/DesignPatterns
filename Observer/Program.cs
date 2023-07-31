using Observer;

//Permite que objetos interessados sejam avisados da mudança de estado ou
//outros eventos ocorrendo num outro objeto.

Cody cody = new Cody();

Inimigo inimigo1 = new Inimigo(cody);
Inimigo inimigo2 = new Inimigo(cody);
Inimigo inimigo3 = new Inimigo(cody);

while (true)
{
    Console.WriteLine("Acertar o Cody com um golpe (S ou N)?");

    if(Console.ReadLine() == "s")
        cody.Golpe_Acertado(true);
    else
        Console.WriteLine("Você não acertou o Cody!");
}