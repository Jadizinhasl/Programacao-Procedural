using System;

class Ex03
{
    static void Main(string[] args)
    {
        int[] inteiro = new int[5];
        int aux;

        Console.WriteLine("Digite 5 números quaisquer:");

        for (int i = 0; i < inteiro.Length; i++)
        {
            inteiro[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < inteiro.Length; i++)
            {
                for(int j = i; j < inteiro.Length; j++)
                

                if(inteiro[i] < inteiro[j])
                {
                    aux = inteiro[i];
                    inteiro[i] = inteiro[j];
                    inteiro[j] = aux;
                }
            }
        Console.WriteLine();
        for (int i = 0; i < inteiro.Length; i++)
        {
            Console.Write(inteiro[i] + " ");
        }
    }
}