using System;

class Ex03
{
    static void Main(string[] args)
    {
        string[,] matriz = new string[4,4];
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if(i == 0)
                {
                    matriz[i,j] = "Vip ";
                }
                else
                {
                    matriz[i,j] = "Associado ";
                }
            }
        }
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if(i == j)
                {
                    matriz[i,j] = "Sorteado ";
                }
                Console.Write("|{0}",matriz[i,j]);
            }
            Console.WriteLine("|");
        }
    }
}