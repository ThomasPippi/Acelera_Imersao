using System;
class Vetor_05
{
  static void Main ()
  {
    int[] vetor = new int[10];	//ExercC-cio pede 80
    int i, maior = 0, menor = 1000000;
      Console.WriteLine ("Validando o menor e maior valor dentro do vetor");
    for (i = 0; i < 10; i++)
      {
	Console.WriteLine ("Digite o valor da posiC'C#o [" + i + "]");
	vetor[i] = int.Parse (Console.ReadLine ());
	if (vetor[i] > maior)
	  {
	    maior = vetor[i];
	  }
	if (vetor[i] < menor)
	  {
	    menor = vetor[i];
	  }
      }
    Console.WriteLine ("Maior: " + maior);
    Console.WriteLine ("Menor: " + menor);
  }
}
