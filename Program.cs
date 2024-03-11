// See https://aka.ms/new-console-template for more information
/*criar matriz de chave (contagem)

para cada elemento da lista

  aumente o respectivo contador em 1

para cada contador, começando pela menor chave

  enquanto o contador é diferente de zero

    restaurar elemento para listar

    diminuir o contador em 1*/

using System.Data;
using System.Reflection.Metadata;

int[] vetor = new int[100];
Random random = new Random();
bool trocou = false;

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(100);
}
for (int i = 0; i < vetor.Length; i++)
{
    // Console.Write($"{vetor[i]},");
}


// ORdenando

do
{
    trocou = false;
    for (int i = 0; i < vetor.Length - 1; i++)
{
    if (vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
        trocou = true;
    }
    
}
} while (trocou == true);

Array.Sort(vetor);

for(int i = 0; i < vetor.Length; i++)
{
    Console.Write($"{vetor[i]},");
}



