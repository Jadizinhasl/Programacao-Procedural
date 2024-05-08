using System;

class Ex02
{
    static void Main(string[] args)
    {
        int tamanho = ReceberTamanho();

        string[,] ampulheta = new string[tamanho, tamanho];
        ImprimirAmpulheta(tamanho, ampulheta);
    }

    static int ReceberTamanho()
    {
        int tamanho = 0;
        while (tamanho % 2 == 0 || tamanho <= 1)
        {
            tamanho = Convert.ToInt32(Console.ReadLine());
            if(tamanho % 2 == 1 && tamanho > 1)
            {
                break;
            }
            Console.WriteLine("O numero digitado deve ser impar e maior que 1");
        }
        return tamanho;
    }

    static void ImprimirAmpulheta(int tamanho, string[,] ampulheta)
    {
        int metade = tamanho / 2;

        for(int i = 0; i < tamanho; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if(i == j)
                {
                    ampulheta[i,j] = "\\";
                }
                if(i + j == tamanho - 1)
                {
                    ampulheta[i,j] = "/";
                }
                if(i == j && i == tamanho/2)
                {
                    ampulheta[i,j] = "X";
                }
                if(ampulheta[i,j] == null)
                {
                    ampulheta[i,j] = " ";
                }
                Console.Write(ampulheta[i,j]);
            }
            Console.WriteLine();
        }
        for(int i = 0; i < tamanho; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}
