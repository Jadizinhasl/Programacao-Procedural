using System;

class Ex03
{
    static void Main(string[] args)
    {
        string[] nomes = new string[5];
        int[] ratings = new int[5];

        int menorRating = int.MaxValue;
        int maiorRating = ratings[0];
        string nomeMaiorRating = nomes[0];
        int somaRatings = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o nome do jogador {0}:", i + 1);
            nomes[i] = Console.ReadLine();

            Console.WriteLine("Digite o rating do jogador {0}:", i + 1);
            ratings[i] = int.Parse(Console.ReadLine());

            somaRatings += ratings[i];

            if (ratings[i] < menorRating)
            {
                menorRating = ratings[i];
            }

            if (ratings[i] > maiorRating)
            {
                maiorRating = ratings[i];
                nomeMaiorRating = nomes[i];
            }
        }
        double mediaRating = (double)somaRatings / 5;

        Console.WriteLine("\nMédia de Rating: {0:F1}", mediaRating);
        Console.WriteLine("Jogador do Primeiro Tabuleiro: {0}", nomeMaiorRating);
        Console.WriteLine("Menor Rating: {0}", menorRating);
    }
}