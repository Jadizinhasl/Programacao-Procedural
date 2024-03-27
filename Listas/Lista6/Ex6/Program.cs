using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        const int TAMANHO = 4;
        int[,] matriz = new int[TAMANHO,TAMANHO];

        for (int linha = 0; linha < TAMANHO; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO; coluna++)
            {
                matriz[linha,coluna] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        Console.WriteLine("Digite o comando que deseja entre 1 e 5:");
        int inteiro = int.Parse(Console.ReadLine());

        if (inteiro == 1)
        {
            for (int linha = 0; linha < TAMANHO; linha++)
            {
                for (int coluna = 0; coluna < TAMANHO; coluna++)
                {
                    Console.WriteLine(matriz[linha,coluna]);
                }
            }
        }
        else if (inteiro == 2)
        {
            for (int linha = 0; linha < TAMANHO; linha++)
            {
                for (int coluna = 0; coluna < TAMANHO; coluna++)
                {
                    somatorio += matriz[linha,coluna];
                }
            } Console.WriteLine(somatorio);
        }
        else if (inteiro == 3)
        {
            for (int linha = 0; linha < TAMANHO; linha++)
            {
                for (int coluna = 0; coluna < TAMANHO; coluna++)
                {
                    if (linha == 2)
                    {
                        somatorio += matriz[linha,coluna];
                    }
                }
            } Console.WriteLine(somatorio);
        }
        else if (inteiro == 4)
        {
            for (int linha = 0; linha < TAMANHO; linha++)
            {
                for (int coluna = 0; coluna < TAMANHO; coluna++)
                {
                    if (linha == coluna)
                    {
                        somatorio += matriz[linha,coluna];
                    }
                }
            } Console.WriteLine(somatorio);
        }
        else if (inteiro == 5)
        {
            for (int linha = 0; linha < TAMANHO; linha++)
            {
                for (int coluna = 0; coluna < TAMANHO; coluna++)
                {
                    if (linha == 1 && coluna % 2 == 0)
                    {
                        somatorio += matriz[linha,coluna];
                    }
                }
            } Console.WriteLine(somatorio);
        }
    }
}
