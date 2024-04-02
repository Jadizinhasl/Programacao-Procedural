using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        PreencherVetor(matriz);
        
        if(VerificarBalistas(matriz))
        {
            Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
        else
        {
            Console.WriteLine("nao ha balistas no tabuleiro");
        }
    }

    static void PreencherVetor(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                matriz[linha,coluna] = int.Parse(Console.ReadLine());

                if (matriz[linha,coluna] < 0 || matriz[linha,coluna] > 9)
                {
                    coluna--;
                }
            }
        }
    }
    static bool VerificarBalistas(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                if (matriz[linha, coluna] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}