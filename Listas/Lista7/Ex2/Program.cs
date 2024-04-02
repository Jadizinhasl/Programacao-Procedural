using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[3];
        Console.WriteLine("Digite três números:");

        for(int contador = 0; contador < 3; contador++)
        {
            vetor[contador] = int.Parse(Console.ReadLine());
        }  
        Console.WriteLine($"O maior número é: {PegarMaiorNumero(vetor)}");
    }

    static int PegarMaiorNumero(int[] vetor)
    {
        int maiorNumero = int.MinValue;

        for(int contador = 0; contador < vetor.Length; contador++)
        {
            if(vetor[contador] > maiorNumero)
            {
                maiorNumero = vetor[contador];
            }
        }
        return maiorNumero;
    }
}
